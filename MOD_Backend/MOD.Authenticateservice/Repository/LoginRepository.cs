using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MOD.Authenticateservice.Context;
using MOD.Authenticateservice.Models;

namespace MOD.Authenticateservice.Repository
{
   
    public class LoginRepository: ILoginRepository
    {
        private readonly LoginContext _context;
        public LoginRepository(LoginContext context)
        {
            _context = context;
        }

        public Mentor MentorLogin(string mid, string mpassword)
        {
            return _context.Mentors.SingleOrDefault(data => data.Mentor_id == mid && data.Mentor_Password== mpassword);
            //if (obj != null)
            //{
            //    return true;
            //}
            //else
            //    return false;
        }

        public user UserLogin(string uid, string upassword)
        {
            return _context.Users.SingleOrDefault(data => data.User_Id ==uid   && data.User_Password == upassword);
            //if (obj != null)
            //{
            //    return true;
            //}
            //else
            //    return false;
        }
    }
}
