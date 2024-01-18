namespace DesignPatternExample.Mediator.After
{
    /// <summary>
    /// 使用中介者 mediator 避免了發送者與接收者多對多複雜的網狀關係，變成 中介者 對 發送者與接收者一對多的放射性關系， 簡化了複雜性
    /// </summary>
    public class UseCase : IUseCase
    {
        public IEnumerable<string> Print()
        {
            var mediator = AirTrafficControlMediator.GetAirTrafficControlMediator();
            var airPlane1 = new Airplane("airPlane1", mediator);
            var airPlane2 = new Airplane("airPlane2", mediator);
            var airPlane3 = new Airplane("airPlane3", mediator);
            var airPlane4 = new Airplane("airPlane4", mediator);

            // 如果專案與專案之間要註冊，可以透過config讀取相關訊息，避免專案上的雙向依賴
            mediator.RegisterAirplane(airPlane1);
            mediator.RegisterAirplane(airPlane2);
            mediator.RegisterAirplane(airPlane3);
            mediator.RegisterAirplane(airPlane4);


            foreach (var msg in airPlane1.Send("hi everyone"))
            {
                yield return msg;
            }

            foreach (var msg in airPlane1.Send("hi everyone", "airPlane2", "airPlane4"))
            {
                yield return msg;
            }
        }
    }
}
