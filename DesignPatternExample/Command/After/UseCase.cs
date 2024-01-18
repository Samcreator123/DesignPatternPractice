using DesignPatternExample.Command.Share;

namespace DesignPatternExample.Command.After
{
    /// <summary>
    /// 新增Invoker 做為 Light 的中介物件，達到解耦合封裝起具體KitchenRoomLight、LivingRoomLight的邏輯
    /// 此時，KitchenRoomLight、LivingRoomLight為所謂的Reciever
    /// </summary>
    public class UseCase : IUseCase
    {
        public IEnumerable<string> Print()
        {
            Invoker invoker = new Invoker();
            ILight kitchenLight = new KitchenRoomLight();
            ILight livingRoomLight = new LivingRoomLight();

            yield return invoker.On(livingRoomLight);
            yield return invoker.On(kitchenLight);
            yield return invoker.Off(kitchenLight);
            yield return invoker.Off(livingRoomLight);
        }
    }
}
