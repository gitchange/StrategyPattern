using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    /// <summary>
    /// FlyWithWings 類別 繼承 FlyBehavior
    /// </summary>
    /// <remark>
    /// History :
    /// 2014/11/20 ChangeWu Create
    /// </remark>
    public class FlyWithWings : FlyBehavior
    {
        /// <summary>
        /// fly 方法
        /// </summary>
        public void fly()
        {
            Console.WriteLine("I am flying !!");
        }
    }
}
