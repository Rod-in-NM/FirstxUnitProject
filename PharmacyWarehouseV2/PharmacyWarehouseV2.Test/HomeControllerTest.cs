using Xunit;
using PharmacyWarehouseV2.Controllers;
using PharmacyWarehouseV2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace PharmacyWarehouseV2.Test
{
    public class HomeControllerTest
    {
        [Fact]
        public void IndexUnitTest()
        {
            //arrange
            //Techncially, this is an integration test, because it's pulling data from the database, rather
            //then using a mock data store.

            var controller = new HomeController(null);

            //var zero = 0;               //I put this in just to ensure that an error would occur
            //var failure = 1 / zero;

            //act
            var result = controller.Index();

            //assert
            if (result != null)
            {
                Assert.IsType<ViewResult>(result);
                var viewResult = result as ViewResult;
                Assert.IsAssignableFrom<List<PharmEmployee>>(viewResult.ViewData.Model);
            }
        }
    }
}