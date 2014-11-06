using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    /// <summary>
    /// MuteQuack 類別 繼承 QuackBehavior
    /// </summary>
    /// <remark>
    /// History :
    /// 2014/11/06 ChangeWu Create
    /// </remark> 
    public class MuteQuack : QuackBehavior
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
            Console.WriteLine("<< Silence >>");
        }
    }
}
