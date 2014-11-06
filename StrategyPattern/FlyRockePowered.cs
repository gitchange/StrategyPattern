using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    /// <summary>
    /// FlyRockePowered類別 繼承 FlyBehavior
    /// </summary>
    /// <remark>
    /// History :
    /// 2014/11/06 ChangeWu Create
    /// </remark>
    public class FlyRockePowered : FlyBehavior
    {
        /// <summary>
        /// fly 方法
        /// </summary>
        /// <remark>
        /// History :
        /// 2014/11/06 ChangeWu Create
        /// </remark>
        public void fly()
        {
            Console.WriteLine("I'm flying with a rocket!");
        }
    }
}
