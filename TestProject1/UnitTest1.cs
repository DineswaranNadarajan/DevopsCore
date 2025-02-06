using DevopsCore.Controllers;
using DevopsCore.Repository;
using DevopsCore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Xunit;
namespace TestProject1
{
    public class UnitTest1
    {
        private PostRepository repository;
        public UnitTest1()
        {
            repository = new PostRepository();
        }
        [Fact]
        public void Test_Index_View_Result()
        {
            //Arrange
            //var controller = new HomeController(this.repository);
            var controller = new HomeController();
            //Act
            var result = controller.Index();
            //Assert
            Assert.IsType<ViewResult>(result);
        }
        [Fact]
        public void Test_Index_Return_Result()
        {
            //Arrange
            //var controller = new HomeController(this.repository);
            var controller = new HomeController();
            //Act
            var result = controller.Index();
            //Assert
            Assert.NotNull(result);
        }
        [Fact]
        public void Test_Index_GetPosts_MatchData()
        {
            //Arrange
            // var controller = new HomeController(this.repository);
            var controller = new HomeController();
            //Act
            var result = controller.Index();
            //Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model =
            Assert.IsAssignableFrom<List<PostModel>>(viewResult.ViewData.Model);
            Assert.Equal(3, model.Count);
            Assert.Equal(101, model[0].iId);
            Assert.Equal("DevOps Demo Title 1", model[0].Name);
        }
    }
}
