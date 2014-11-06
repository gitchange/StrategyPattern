using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    /// <summary>
    /// 我不能飛 FlyNoWay 類別 繼承 FlyBehavior
    /// </summary>
    /// <remark>
    /// History :
    /// 2014/11/06 ChangeWu Create
    /// </remark>
    public class FlyNoWay : FlyBehavior
    {
        /// <summary>
        /// 我不能飛-fly方法
        /// </summary>
        public void fly()
        {
            int s = 0;
            Console.WriteLine("I can't fly");
            s = myAdd(2, 3);
            Console.WriteLine("s=" + s.ToString());
        }
        /// <summary>
        /// 這是一個加法的函數
        /// </summary>
        /// <param name="a">請輸入第一個數字</param>
        /// <param name="b">請輸入第二個數字</param>
        /// <returns>回傳兩個參數數值的總和</returns>
        /// <remark>
        /// History :
        /// 2014/11/06 ChangeWu Create
        /// 2014/11/08 ChangeWu for IT Req. TN201411000068 修正加法的邏輯
        /// </remark>
        private int myAdd(int a , int b)
        {
            return a + b;
        }
    }
}
