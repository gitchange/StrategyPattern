using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    /// <summary>
    /// Quack 類別
    /// </summary>
    public class Quack : QuackBehavior
    {
        /// <summary>
        /// quack 方法
        /// </summary>
        public void quack()
        {
            Console.WriteLine("Quack");
        }
    }
}
