using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    /// <summary>
    /// FlyRockePowered類別
    /// </summary>
    public class FlyRockePowered : FlyBehavior
    {
        /// <summary>
        /// fly 方法
        /// </summary>
        public void fly()
        {
            Console.WriteLine("I'm flying with a rocket!");
        }
    }
}
