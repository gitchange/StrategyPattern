using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    /// <summary>
    /// Quack 類別 繼承 QuackBehavior
    /// </summary>
    /// <remark>
    /// History :
    /// 2014/11/06 ChangeWu Create
    /// </remark> 
    public class Quack : QuackBehavior
    {
        /// <summary>
        /// quack 方法
        /// </summary>
        /// <remark>
        /// History :
        /// 2014/11/06 ChangeWu Create
        /// </remark> 
        public void quack()
        {
            Console.WriteLine("Quack");
        }
    }
}
