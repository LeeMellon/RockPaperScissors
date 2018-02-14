using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using RockPaper.Controllers;
using RockPaper.Models;

namespace RockPaper.Tests
{
    [TestClass]
    public class HomeControllerTest
    {
      [TestMethod]
      public void Index_ReturnsCorrectView_True()
      {
        HomeController controller = new HomeController();
        IActionResult indexView = controller.Index();
        ViewResult result = indexView as ViewResult;
        Assert.IsInstanceOfType(result, typeof(ViewResult));
      }
      [TestMethod]
        public void Index_HasCorrectModelType_ResultString()
        {
            //Arrange
            ViewResult indexView = new HomeController().GameResult() as ViewResult;
            //Act
            var result = indexView.ViewData.Model;
            System.Console.WriteLine(result==null);
            //Assert
            Assert.IsInstanceOfType(result, typeof(string));
        }
    }
}
