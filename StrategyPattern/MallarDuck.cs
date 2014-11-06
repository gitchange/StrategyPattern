using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    /// <summary>
    /// MallarDuck 類別 繼承 Duck
    /// </summary>
    /// <remark>
    /// History :
    /// 2014/11/06 ChangeWu Create
    /// </remark>    
    public class MallarDuck : Duck
    {
        /// <summary>
        /// MallarDuck 方法
        /// </summary>
        /// <remark>
        /// History :
        /// 2014/11/06 ChangeWu Create
        /// </remark> 
        public MallarDuck()
        {
            quackbehavior = new Quack();
            flybehavior = new FlyWithWings();
        }

        /// <summary>
        /// 覆寫display 方法
        /// </summary>
        /// <remark>
        /// History :
        /// 2014/11/06 ChangeWu Create
        /// </remark> 
        public override void display()
        {
            Console.WriteLine("I'm a real Mallard duck");
        }
    }
}
