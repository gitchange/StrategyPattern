using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    /// <summary>
    /// 設計模式 - 策略模式 主程式
    /// </summary>
    /// <remark>
    /// History :
    /// 2014/11/03 ChangeWu Create
    /// </remark>
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallarDuck();
            mallard.performFly();
            mallard.performQuack();

            Duck model = new ModelDuck();
            model.performFly();
            model.setFlyBehavior(new FlyRockePowered());
            model.performFly();
        }

    }
}
