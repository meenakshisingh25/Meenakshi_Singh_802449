using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOD.Technologyservice.Models;
using MOD.Technologyservice.Repository;

namespace MOD.Technologyservice.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class SkillController : ControllerBase
    {

        private readonly ISkillRepository _repository;
        public SkillController(ISkillRepository repository)
        {
            _repository = repository;
        }
        // GET: api/Skill
        [HttpGet]
        [Route("GetAll")]
        public IEnumerable<Skill> Get()
        {
            return _repository.GetSkills();
        }

        // GET: api/Skill/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Skill
        [HttpPost]
        [Route("Add")]
        public IActionResult Post(/*[FromBody]*/ Skill item)
        {
            _repository.Skill_Add(item);
            return Ok(/*"Record Added"*/);
        }

        // PUT: api/Skill/5
        [HttpPut("{id}")]
        [Route("Update/{id}")]
        public  IActionResult Put(/*string id, [FromBody]*/ Skill item)
        {
            _repository.Skill_Update(item);
            return Ok();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        [Route("Delete/{id}")]
        public  IActionResult Delete(string id)
        {
            _repository.Skill_Delete(id); return Ok();
        }

        [HttpDelete("{id}")]
        [Route("Delete/{name}")]

        [Route("GetName/{name}")]
        public Skill GetName(string name)
        {
            return _repository.GetName(name);
        }
    }
}
