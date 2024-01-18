using DesignPatternExample.Command.Share;

namespace DesignPatternExample.Command.After
{
    /// <summary>
    /// 新增Command 做為 Light與Invoker 的中介物件，達到封裝起具體KitchenRoomLight、LivingRoomLight的邏輯
    /// 此時，KitchenRoomLight、LivingRoomLight為所謂的Reciever
    /// 也可以自由調整Command的順序
    /// </summary>
    public class UseCase : IUseCase
    {
        public IEnumerable<string> Print()
        {
            ILight kitchenLight = new KitchenRoomLight();
            ILight livingRoomLight = new LivingRoomLight();

            Invoker invoker = new Invoker();
            invoker.AddLightCommand(new TurnOnCommand(kitchenLight));
            invoker.AddLightCommand(new TurnOnCommand(livingRoomLight));
            invoker.AddLightCommand(new TurnOffCommand(kitchenLight));
            invoker.AddLightCommand(new TurnOffCommand(livingRoomLight));

            foreach (var item in invoker.Execute())
            {
                yield return item;
            }
        }
    }
}
