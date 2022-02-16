using System;
using Xunit;
using DevOpsDemo.Models;
using DevOpsDemo.Repository;
using DevOpsDemo.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DevOpsDemo.Test
{
    public class PostTestController
    {
        private PostRepository repository;
        public PostTestController()
        {
            repository = new PostRepository();
        }
        [Fact]
        public void Test_Index_View_Result()
        {
            //Arrange 
            var controller = new HomeController(null, this.repository);

            //Act
            var result = controller.Index();
            //Assert
            Assert.IsType<ViewResult>(result);
        }
        [Fact]
        public void Test_Index_Return_Result()
        {
            //Arrange 
            var controller = new HomeController(null,this.repository);
            //Act
            var resutl = controller.Index();
            //Assert
            Assert.NotNull(resutl);
        }
        [Fact]
        public void Tesgt_Index_GetPosts_MatchData()
        {
            //Arrange
            var controller = new HomeController(null, this.repository);
            //Act
            var result = controller.Index();
            //Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<List<PostViewModel>>(viewResult.ViewData.Model);
            Assert.Equal(3, model.Count);
            Assert.Equal(101, model[0].PostId);
            Assert.Equal("DevOps Demo Title 1", model[0].Title);
        }
    }
}
