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
    public class UserController : ControllerBase
    {
        private readonly IUser_Repository _repository;

        public UserController(IUser_Repository repository)
        {
            _repository = repository;
        }
        // GET: api/User/GetAll
        [HttpGet]
        [Route("GetAll")]
        public IEnumerable<user> Get()
        {
            return _repository.GetAll();
        }

        //Get:api/user/SearchMentor
        [HttpGet]
        [Route("SearchMentor/{technology}/{timeslot}")]
        public IEnumerable<Mentor> Get(string technology, string timeslot)
        {
            return _repository.SearchMentor(technology, timeslot);
        }

        // POST: api/User/Add
        [HttpPost]
        [Route("Add")]
        public IActionResult Post([FromBody] user item)
        {
            _repository.User_Add(item);
            return Ok("Record Added");
        }

        // PUT: api/User/5
        [HttpPut("{id}")]
        [Route("Update/{id}")]
        public void Put(user item)
        {
            _repository.User_Update(item);
        }

        //PUT: api/User/ResetPassword/5
        [HttpPut("{id}")]
    [Route("ResetPassword/{email}/{newpass}")]
    public void PutPassword(string email,string newpass)
    {
        _repository.User_ResetPassword(email, newpass);
    }
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        
        [Route("Delete/{id}")]
        public void Delete(string id)
        {
            _repository.User_Delete(id);
        }
    }
}
