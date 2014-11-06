using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    /// <summary>
    /// QuackBehavior 介面
    /// </summary>
    /// <remark>
    /// History :
    /// 2014/11/06 ChangeWu Create
    /// </remark>
    public interface QuackBehavior
    {
        /// <summary>
        /// Interface : QuackBehavior . quack() 呱呱叫
        /// </summary>
        /// <remark>
        /// History :
        /// 2014/11/06 ChangeWu Create
        /// </remark> 
        void quack();
    }
}
