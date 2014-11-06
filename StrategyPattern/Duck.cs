using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    /// <summary>
    /// Duck(抽象)類別
    /// </summary>
    /// <remark>
    /// History :
    /// 2014/11/06 ChangeWu Create
    /// 2014/11/07 ChangeWu for IT Req. TN201411000023 修正 User 提出的 Data Bug
    /// </remark>
    public abstract class Duck
    {      
        /// <summary>
        /// 變數 flybehavior 的型別是 FlyBehavior
        /// </summary>
        protected FlyBehavior flybehavior;
        /// <summary>
        /// 變數 quackbehavior 的型別是 QuackBehavior
        /// </summary>
        protected QuackBehavior quackbehavior;

        /// <summary>
        /// performQuack 執行呱呱叫的方法
        /// </summary>
        public void performQuack()
        {
            quackbehavior.quack();
        }

        /// <summary>
        /// swim 執行游泳的方法
        /// </summary>
        /// <remark>
        /// History :
        /// 2014/11/06 ChangeWu Create
        /// 2014/11/07 ChangeWu for IT Req. TN201411000023 修正 User 提出的 Data Bug
        /// </remark>
        public void swim()
        {
            Console.WriteLine("All ducks float , even decoys!");
        }

        /// <summary>
        /// display 顯示外觀的(抽象)方法
        /// </summary>
        public abstract void display() ;

        /// <summary>
        /// performFly 執行飛行的方法
        /// </summary>
        public void performFly()
        {
            flybehavior.fly();
        }

        /// <summary>
        /// setFlyBehavior 設定飛行的方法
        /// </summary>
        /// <param name="fb">傳入一個飛行行為(FlyBehavior)類別</param>
        public void setFlyBehavior(FlyBehavior fb)
        {
            flybehavior = fb;
        }

        /// <summary>
        /// setQuackBehavior 設定呱呱叫的方法
        /// </summary>
        /// <param name="qb">傳入一個Quack行為(QuackBehavior)類別</param>
        public void setQuackBehavior(QuackBehavior qb)
        {
            quackbehavior = qb;
        }
    }
}
