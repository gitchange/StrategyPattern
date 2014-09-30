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
    public abstract class Duck
    {
        protected FlyBehavior flybehavior;
        protected QuackBehavior quackbehavior;

        /// <summary>
        /// performQuack 方法 777
        /// </summary>
        public void performQuack()
        {
            quackbehavior.quack();
        }

        /// <summary>
        /// swim 方法
        /// </summary>
        public void swim()
        {
            Console.WriteLine("All ducks float , even decoys!");
        }

        /// <summary>
        /// display 抽象方法
        /// </summary>
        public abstract void display() ;

        /// <summary>
        /// performFly 方法
        /// </summary>
        public void performFly()
        {
            flybehavior.fly();
        }

        /// <summary>
        /// setFlyBehavior 方法
        /// </summary>
        /// <param name="fb">傳入一個飛行行為(FlyBehavior)類別</param>
        public void setFlyBehavior(FlyBehavior fb)
        {
            flybehavior = fb;
        }

        /// <summary>
        /// setQuackBehavior 方法
        /// </summary>
        /// <param name="qb">傳入一個Quack行為(QuackBehavior)類別</param>
        public void setQuackBehavior(QuackBehavior qb)
        {
            quackbehavior = qb;
        }
    }
}
