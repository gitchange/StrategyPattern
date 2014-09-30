using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    /// <summary>
    /// FlyBehavior 介面
    /// </summary>
    public interface FlyBehavior
    {
        /// <summary>
        /// 抽象方法：fly()
        /// </summary>
        public abstract void fly();
    }
}
