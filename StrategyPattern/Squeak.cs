using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    /// <summary>
    /// Squeak 類別
    /// </summary>
    public class Squeak : QuackBehavior
    {
        /// <summary>
        /// Squeak 類別 - quack 方法
        /// </summary>
        public void quack()
        {
            Console.WriteLine("Squeak");
        }
    }
}
