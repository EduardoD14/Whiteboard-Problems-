using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReturnSumOfDigits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnSumOfDigits.Tests
{
    [TestClass()]
    public class ReturnSumOfDigitsTests
    {
        [TestMethod()]
        public void SumDigTest()
        {        
            Assert.AreEqual(1, ReturnSumOfDigits.SingleSumDig(1234));
        }
         [TestMethod()]
        public void SumDigTest1()
        {   
            Assert.AreEqual(6, ReturnSumOfDigits.SingleSumDig(12345));
        }
    }          
}