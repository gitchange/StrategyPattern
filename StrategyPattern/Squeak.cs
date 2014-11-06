using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    /// <summary>
    /// Squeak 類別 繼承 QuackBehavior
    /// </summary>
    /// <remark>
    /// History :
    /// 2014/11/06 ChangeWu Create
    /// </remark>
    public class Squeak : QuackBehavior
    {
        /// <summary>
        /// Squeak 類別 - quack 方法
        /// </summary>
        /// <remark>
        /// History :
        /// 2014/11/06 ChangeWu Create
        /// </remark>
        public void quack()
        {
            Console.WriteLine("Squeak");
        }
    }
}
