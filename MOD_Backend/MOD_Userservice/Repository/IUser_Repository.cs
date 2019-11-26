using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MOD.Userservice.Models;


namespace MOD.Userservice.Repository
{
    public interface IUser_Repository
    {
        IList<user> GetAll();
        void User_Add(user item);
        void User_Update(user item);
        void User_Delete(string id);
        void User_ResetPassword(string email,string newpass);
        IList<Mentor> SearchMentor(string technology, string timeslot);
    }
}
