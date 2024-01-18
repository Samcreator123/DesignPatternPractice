using DesignPatternExample.Builder.Share;


namespace DesignPatternExample.Builder.Before
{
    //這樣Car每增加一個新的配件寫在建構子會有兩種方式
    // 1. 更新原本的建構子 => 違反開放封閉原則
    // 2. 新增依照商業邏輯的建構子 => 隨著商業邏輯會有很多個建構子
    // 除了增加新的配件會有的上述問題 還會有
    // 建構子邏輯複雜，在配件多的情況下建構子會很長
    public class Car
    {
        GPS _gps;
        HeatedSW _heatedSW;
        Sunroof _sunroof;

        public Car(bool hasGPS, bool hasHeatedSW, bool hasSunroof)
        {
            if(hasGPS) _gps = new GPS();
            if(hasHeatedSW) _heatedSW = new HeatedSW();
            if(hasSunroof) _sunroof = new Sunroof();
        }
    }
}
