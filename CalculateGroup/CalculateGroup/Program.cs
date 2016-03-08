using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate calculateGroup = new Calculate();
            Console.WriteLine("起始Calculate物件");

            List<Products> data =  calculateGroup.GetCollectDate();
            Console.WriteLine("使用GetCollectData Function 取出物件");

            #region 3筆一組，取Cost總和
            object[] costGroup = new object[] { 3,"cost" };

            int [] costSum = calculateGroup.CalGroupSum(data, costGroup);
            Console.WriteLine("計算群組總合的物件陣列");
            Console.WriteLine(ShowAry(costSum));
            #endregion

            #region 4筆一組，取Revenue總和
            object[] revenueGroup = new object[] { 4, "revenue" };

            int [] revenueSum = calculateGroup.CalGroupSum(data, revenueGroup);
            Console.WriteLine("計算群組總合的物件陣列");
            Console.WriteLine(ShowAry(revenueSum));

            #endregion
        }

        private static string ShowAry(int[] ary)
        {
            string showAry = "";

            for (int i = 0; i < ary.Length; i++)
            {
                showAry += ary[i].ToString() + ",";
            }
            return showAry.TrimEnd(',');
        }
    }
}
