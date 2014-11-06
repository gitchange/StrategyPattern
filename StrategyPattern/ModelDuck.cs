using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    /// <summary>
    /// ModelDuck 類別 繼承 Duck
    /// </summary>
    /// <remark>
    /// History :
    /// 2014/11/06 ChangeWu Create
    /// </remark> 
    public class ModelDuck : Duck
    {
        /// <summary>
        /// ModelDuck 方法
        /// </summary>
        /// <remark>
        /// History :
        /// 2014/11/06 ChangeWu Create
        /// </remark> 
        public ModelDuck()
        {
            flybehavior = new FlyNoWay();
            quackbehavior = new Quack();
        }

        /// <summary>
        /// 覆寫 display 方法
        /// </summary>
        /// <remark>
        /// History :
        /// 2014/11/06 ChangeWu Create
        /// </remark> 
        public override void display()
        {
            Console.WriteLine("I am a model duck");
        }
    }
}
