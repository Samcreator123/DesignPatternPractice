using DesignPatternExample.Command.Share;

namespace DesignPatternExample.Command.Before
{
    /// <summary>
    /// 在沒有命令模式的情況下，客戶端(UseCase)要了解物件的具體行為(商業邏輯)，使用命令模式後，一物件(Invoker)做為客戶端與商業邏輯，使雙方解耦合
    /// 更改、新增功能時只需要更改商業邏輯、監控、Log也可於Invoker做好就好，達到關注點分離
    /// </summary>
    public class UseCase : IUseCase
    {
        public IEnumerable<string> Print()
        {
            ILight kitchenLight = new KitchenRoomLight();
            ILight livingRoomLight = new LivingRoomLight();

            yield return kitchenLight.On();
            yield return kitchenLight.Off();
            yield return livingRoomLight.On();
            yield return livingRoomLight.Off();

        }
    }
}
