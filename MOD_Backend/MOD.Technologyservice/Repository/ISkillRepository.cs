using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MOD.Technologyservice.Models;

namespace MOD.Technologyservice.Repository
{
     public interface ISkillRepository
    {

        void Skill_Add(Skill item);
        IEnumerable<Skill> GetSkills();
        void Skill_Update(Skill item);
        void Skill_Delete(string id);

        Skill GetName(string name);

    }
}
