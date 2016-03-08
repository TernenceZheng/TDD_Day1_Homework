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
            Dictionary<int, int> threeGroupSum = calculateGroup.CalGroupSum(data);
            Console.WriteLine("計算群組總合的物件陣列");

            Console.WriteLine();
            #endregion

            #region 4筆一組，取Revenue總和
            Dictionary<int, int> fourGroupSum = calculateGroup.CalGroupSum(data);
            Console.WriteLine("計算群組總合的物件陣列");

            Console.WriteLine();

            #endregion
        }
    }
}
