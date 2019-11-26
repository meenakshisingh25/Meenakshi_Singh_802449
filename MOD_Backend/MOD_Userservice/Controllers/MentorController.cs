using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOD.Userservice.Models;
using MOD.Userservice.Repository;

namespace MOD.Userservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    
    public class MentorController : ControllerBase
    {
        private readonly IMentorRepository _repository;

        public MentorController(IMentorRepository repository)
        {
            _repository = repository;
        }
        // GET: api/Mentor/GetAll
        [HttpGet]
        [Route("GetAll")]
        public IEnumerable<Mentor> Get()
        {
            return _repository.GetAll();
        }

        // GET: api/Mentor/5
        //[HttpGet("{id}", Name = "Get")]
        //[Route("GetById/{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST: api/Mentor
        [HttpPost]
        [Route("Add")]
        public IActionResult Post([FromBody] Mentor item )
        {
            _repository.Mentor_Add(item);
            return Ok("Record Added");
        }

        // PUT: api/Mentor/5
        [HttpPut("{id}")]
        [Route("Update/{id}")]
        public void Put(int id, [FromBody] Mentor item )
        {
            _repository.Mentor_Update(item);
        }


        //PUT: api/Mentor/ResetPassword/5
        [HttpPut("{id}")]
        [Route("ResetPassword/{email}/{newpass}")]
        public void PutPassword(string email, string newpass)
        {
            _repository.Mentor_ResetPassword(email, newpass);
        }


        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        [Route("Delete/{id}")]
        public void Delete(string id)
        {
            _repository.Mentor_Delete(id);
        }
    }
}
