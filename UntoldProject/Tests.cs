using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using UntoldProject.PageObjects;

namespace UntoldProject
{
    [TestFixture]
    class Tests : Hooks
    {
        [Test]
        public void menuSearch()
        {
            //Arrange
            HomePage homePage = new HomePage(Driver);
            Thread.Sleep(millisecondsTimeout: 2000);


            //Act
            homePage.menuSearch();

            //Assert
            Assert.IsFalse(homePage.menuList.Displayed);
           
        }
    }
}
