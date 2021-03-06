﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests
{
    [TestClass]
    public class CalculatorOpClass
    {
        [TestMethod]
        public void ShouldAddReturnNineWhenPassFiveandFour()
        {
            
            //Average
            CalculatorOp sut = new CalculatorOp();
            //Act
            int result = sut.Add(5, 4);
            //Assert
            Assert.AreEqual(9, result);
        }

        [TestMethod]
        public void ShouldMulReturnTwentyWhenPassFiveAndFour()
        {
            //Arrange
            CalculatorOp sut = new CalculatorOp();

            //Act
            int result = sut.Mul(5, 4);
            //Assert
            Assert.AreEqual(20, result);
        }

    }
}
