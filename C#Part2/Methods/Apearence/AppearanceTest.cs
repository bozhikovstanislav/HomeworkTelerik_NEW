using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Appearence;
namespace AppearanceTest
{
    [TestClass]
    public class AppearanceTest
    {
        [TestMethod]
        public void CountANumberInArrayTest()
        {
            
            int[]arra=
            {
                      2,2,2,2,3,5,6,1,1
            };
            int n = 2;
            int count = Appearence.Appearence.CountANumberInArray(arra, n);
            int countTest = 4;

            Assert.AreEqual(countTest, count);
        }
    }
}
