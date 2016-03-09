using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculateGroup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateGroup.Tests
{
    [TestClass()]
    public class CalculateTests
    {
        [TestMethod()]
        public void GetCollectDateTest()
        {
            //arrange 
            Calculate target = new Calculate();

            List<Products> productList = new List<Products>();
            productList.Add(new Products() { ID = 1 ,Cost = 1, Revenue = 11,SellPrice = 21 });
            productList.Add(new Products() { ID = 2, Cost = 2, Revenue = 12, SellPrice = 22 });
            productList.Add(new Products() { ID = 3, Cost = 3, Revenue = 13, SellPrice = 23 });
            productList.Add(new Products() { ID = 4, Cost = 4, Revenue = 14, SellPrice = 24 });
            productList.Add(new Products() { ID = 5, Cost = 5, Revenue = 15, SellPrice = 25 });
            productList.Add(new Products() { ID = 6, Cost = 6, Revenue = 16, SellPrice = 26 });
            productList.Add(new Products() { ID = 7, Cost = 7, Revenue = 17, SellPrice = 27 });
            productList.Add(new Products() { ID = 8, Cost = 8, Revenue = 18, SellPrice = 28 });
            productList.Add(new Products() { ID = 9, Cost = 9, Revenue = 19, SellPrice = 29 });
            productList.Add(new Products() { ID = 10, Cost = 10, Revenue = 20, SellPrice = 30 });
            productList.Add(new Products() { ID = 11, Cost = 11, Revenue = 21, SellPrice = 31 });

            var expected = productList;

            //act
            var actual = target.GetCollectDate();

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalGroupSumTest()
        {
            Assert.Fail();
        }
    }
}