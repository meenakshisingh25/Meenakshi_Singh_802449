using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOD.TrainingService.Models;
using MOD.TrainingService.Repository;

namespace MOD.TrainingService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainingController : ControllerBase
    {
        private readonly ITrainingRepository _repository;
        public TrainingController(ITrainingRepository repository)
        {
            _repository = repository;
        }
        // GET: api/Training
        [HttpGet]
        [Route("GetAll")]
        public IEnumerable<Training> Get()
        {
            return _repository.GetAll();
        }
        [HttpGet]
        [Route("CompleteTraining/{Mentor_ID}")]
        public List<Training> GetCompleteTraining(string Mentor_ID)
        {
            return _repository.CompleteTraining(Mentor_ID);
        }
        [HttpGet]
        [Route("CurrentTraining/{Mentor_ID}")]
        public List<Training> GetCurrentTraining(string Mentor_ID)
        {
            return _repository.CurrentTraining(Mentor_ID);
        }

        [HttpGet]
        [Route("UserCompleteTraining/{User_ID}")]
        public List<Training> GetUserCompleteTraining(string User_ID)
        {
            return _repository.UserCompleteTraining(User_ID);
        }
        [HttpGet]
        [Route("UserCurrentTraining/{Mentor_ID}")]
        public List<Training> GetUserCurrentTraining(string User_ID)
        {
            return _repository.CurrentTraining(User_ID);
        }
        //// GET: api/Training/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST: api/Training
        [HttpPost]
        [Route("Add")]
        public IActionResult Post([FromBody] Training item)
        {
            _repository.Training_Add(item);
            return Ok("Record Added");
        }

        // PUT: api/Training/5
        [HttpPut("{id}")]
        [Route("Update/{id}")]
        public void Put(string id, [FromBody] Training item)
        {
            _repository.Training_Update(item);
        }

        //// DELETE: api/ApiWithActions/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
