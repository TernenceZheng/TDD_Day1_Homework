using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace CalculateGroup
{
    public class Calculate
    {
        public List<Products> GetCollectDate()
        {
            //原始資料
            List<Products> productList = new List<Products>();

            for (int i = 1; i < 12; i++)
            {
                Products product = new Products();
                product.ID = i; //new Random().Next(0, 999);
                product.Cost = i ;
                product.Revenue = i + 10;
                product.SellPrice = i + 20;

                productList.Add(product);
            }
            return productList;
        }

        public int[] CalGroupSum(List<Products> oriData, object[] expectedObj)
        {
            //先把要取得分組數目取出，要分組的屬性名稱取出
            int groupNum = 0;
            string propertyName = "";
            foreach (object item in expectedObj)
            {
                int tempNum = 0;
                if (int.TryParse(item.ToString(),out tempNum))
                {
                    groupNum = tempNum;
                    continue;
                }

                Type type = typeof(Products);
                foreach (PropertyInfo property in type.GetProperties())  //逐一取出物件
                {
                    if (property.Name.ToUpper() == item.ToString().ToUpper())
                    {
                        propertyName = property.Name;
                    }
                }

            }

            //先取得要產生陣列的長度
            //分母
            int aryLength = oriData.Count / groupNum;

            if (oriData.Count % groupNum > 0)
            {
                aryLength += 1;
            }  

            int[] objResult = new int[aryLength];

            int[] allSelect = MyDynamicSelect(oriData, propertyName);
            int index = 0;
            int sum = 0;
            for (int i = 0; i < allSelect.Length; i++)
            {
                sum += allSelect[i];

                if ((i + 1) % groupNum == 0 || (i + 1) == allSelect.Length)
                {
                    objResult[index] = sum;
                    sum = 0;
                    index++;
                }
            }

            return objResult;
        }

        #region Class Private Function
        private int[] MyDynamicSelect(List<Products> list, string selectName)
        {
            int[] result = new int[list.Count];
            var data = new Products();
            var type = data.GetType();
            for (var i = 0; i < list.Count; i++)
            {
                foreach (var property in data.GetType().GetProperties())
                {
                    if (property.Name == selectName)
                    {
                        result[i] = GetPropValue(list[i], selectName);
                    }
                }
            }
            return result;
        }
        private int GetPropValue(object src, string propName)
        {
            var o = src.GetType().GetProperty(propName).GetValue(src, null);

            if (o != null)
            {
                return int.Parse(o.ToString());
            }
            else
            {
                return 0;
            }

        }
        #endregion
    }
}