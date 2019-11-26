using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MOD.Userservice.Models;

namespace MOD.Userservice.Repository
{
   public interface IMentorRepository
    {
        void Mentor_Add(Mentor item);
        IList<Mentor> GetAll();
        void Mentor_Update(Mentor item);
        void Mentor_Delete(string id);
        void Mentor_ResetPassword(string email, string newpass);
    }
}
