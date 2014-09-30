using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    /// <summary>
    /// MuteQuack 類別
    /// </summary>
    public class MuteQuack : QuackBehavior
    {
        /// <summary>
        /// quack 方法
        /// </summary>
        public void quack()
        {
            Console.WriteLine("<< Silence >>");
        }
    }
}
