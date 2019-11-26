using System;
using System.Collections.Generic;
using System.Text;
using Moq;
using MOD.Technologyservice.Repository;
using MOD.Technologyservice.Models;
using MOD.Technologyservice.Controllers;
using Xunit;
using Microsoft.AspNetCore.Mvc;

namespace MOD.TestingService
{
   public class SkillControllertTest
    {
        private readonly Mock<ISkillRepository> _repo;
        private readonly SkillController _controller;

        public SkillControllertTest()
        {
            _repo = new Mock<ISkillRepository>();
            _controller = new SkillController(_repo.Object);
        }

        [Fact]
        public void Get()
        {
            _repo.Setup(m => m.GetSkills()).Returns(GetSkills());
            var result = _controller.Get() as List<Skill>;
            Assert.Equal(3, result.Count);
        }
        [Fact]
        public void GetByID()
        {
            //ARRANGE
            _repo.Setup(m => m.GetName("Java")).Returns(GetSkills()[0]);
            //act
            var result = _controller.GetName("Java") as Skill;
            //assert
            Assert.NotNull(result);
            Assert.Equal("Java", result.SkillName);
        }

        [Fact]
        public void Post()
        {
            var item = GetSkills()[0];
            var result = _controller.Post(item) as OkResult;
            Assert.NotNull(result);
        }
        [Fact]
        public void Put()
        {
            var item = GetSkills()[0];
            var result = _controller.Put(item) as OkResult;
            Assert.NotNull(result);
        }

        [Fact]
        public void Delete()
        {
            _repo.Setup(m=>m.Skill_Delete(It.IsAny<string>()));
            var result = _controller.Delete("Java") as OkResult;
            Assert.NotNull(result);
        }

        //[Fact]
        //public void Delete_BadRequest
        // creating fake data......
        private List<Skill> GetSkills()
        {
            return new List<Skill>()
            {
                new Skill(){ SkillId="s001", SkillName="Java"},
                new Skill(){ SkillId="s002", SkillName="Java1"},
                new Skill(){ SkillId="s003", SkillName="Java2"}
            };
        }

    }
}
