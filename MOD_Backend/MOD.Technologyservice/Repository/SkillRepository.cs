using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MOD.Technologyservice.Context;
using MOD.Technologyservice.Models;



namespace MOD.Technologyservice.Repository
{
    public class SkillRepository : ISkillRepository
    {
        private readonly TechnologyServiceContext _context;

        public SkillRepository(TechnologyServiceContext context)
        {
            _context = context;
        }

        

        public IEnumerable<Skill> GetSkills()
        {
            return _context.Skills.ToList();
        }

        public void Skill_Add(Skill item)
        {
            try
            {
                _context.Skills.Add(item);
                _context.SaveChanges();
            }
            catch(Exception)
            {
                throw;
            }
        }

        public void Skill_Delete(string id)
        {
            try
            {
                var item = _context.Skills.Find(id);
                _context.Skills.Remove(item);
                _context.SaveChanges();
            }
            catch(Exception)
            {
                throw;
            }
        }



        public void Skill_Update(Skill item)
        {
            try
            {
                _context.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.SaveChanges();
            }
            catch(Exception)
            {
                throw;
            }
        }

      public  Skill GetName(string name)
        {
            try
            {
                return _context.Skills.SingleOrDefault(i => i.SkillName == name);
            }
            catch(Exception)
            {
                throw;
            }

        }
    }
}
