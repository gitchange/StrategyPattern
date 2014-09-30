using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    /// <summary>
    /// MallarDuck 類別
    /// </summary>
    public class MallarDuck : Duck
    {
        /// <summary>
        /// MallarDuck 方法
        /// </summary>
        public MallarDuck()
        {
            quackbehavior = new Quack();
            flybehavior = new FlyWithWings();
        }

        /// <summary>
        /// 覆寫display 方法
        /// </summary>
        public override void display()
        {
            Console.WriteLine("I'm a real Mallard duck");
        }
    }
}
