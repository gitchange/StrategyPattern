using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    /// <summary>
    /// FlyBehavior 介面
    /// </summary>
    /// <remark>
    /// History :
    /// 2014/11/06 ChangeWu Create
    /// </remark>
    public interface FlyBehavior
    {
        /// <summary>
        /// 抽象方法：飛行 fly()
        /// </summary>
        void fly();
    }
}
