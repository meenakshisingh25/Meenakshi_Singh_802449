using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MOD.Authenticateservice.Models;

namespace MOD.Authenticateservice.Repository
{
  public   interface ILoginRepository
    {
       user UserLogin(string uid, string upassword);
        Mentor MentorLogin(string mid, string mpassword);
    }
}
