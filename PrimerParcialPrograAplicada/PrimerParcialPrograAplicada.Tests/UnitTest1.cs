using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimerParcialPrograAplicada.Controllers;

namespace PrimerParcialPrograAplicada.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGet()
        {
            callausController callausController = new callausController();
            var callau = callausController.Getcallaus();
            Assert.IsNotNull(callau);
        }
       
    }
}
