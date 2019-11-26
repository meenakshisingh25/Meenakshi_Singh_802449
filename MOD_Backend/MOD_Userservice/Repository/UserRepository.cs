using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MOD.Userservice.Contextin;
using MOD.Userservice.Models;

namespace MOD.Userservice.Repository
{
    public class UserRepository : IUser_Repository
    {
        public readonly UserServiceContext _context;

        public UserRepository(UserServiceContext context)
        {
            try
            {
                _context = context;
            }
            catch(Exception)
            {
                throw;
            }
        }

        public IList<user> GetAll()
        {
            try
            {
                return _context.Users.ToList();
            }
            catch(Exception)
            {
                throw;
            }
        }

        public IList<Mentor> SearchMentor(string technology ,string timeslot)
        {
            try
            {
                var obj = _context.Mentors.Where(s => s.Mentor_Primary_Skill == technology || s.Mentor_timeslot == timeslot).ToList();
                return obj;
            }
            catch(Exception)
            {
                throw;
            }
        }

        public void User_Add(user item)
        {
            try
            {
                _context.Users.Add(item);
                _context.SaveChanges();
            }
            catch(Exception)
            {
                throw;
            }
        }

        //public void User_Delete(int id)
        //{
        //    var item = _context.Users.Find(id);
        //    _context.Users.Remove(item);
        //    _context.SaveChanges();
        //}

        public void User_Delete(string id)
        {

            try
            {
                var item = _context.Users.Find(id);
                _context.Users.Remove(item);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        //public void User_ResetPassword(user item)
        //{
        //    var obj = _context.Users.SingleOrDefault(i => i.User_Email.Equals(i));
        //    obj.User_Password = item.User_Password;
        //    _context.SaveChanges();
        //}

        public void User_Update(user item)
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

        public void ResetPassword(string email, string newpass)
        {
            try
            {
                var obj = _context.Users.SingleOrDefault(i => i.User_Email == email);
                obj.User_Password = newpass;
                _context.SaveChanges();
            }
            catch(Exception)
            {
                throw;
            }
        }

        public void User_ResetPassword(string email, string newpass)
        {
            try
            {
                var obj = _context.Users.SingleOrDefault(i => i.User_Email == email);
                obj.User_Password = newpass;
                _context.SaveChanges();
            }
            catch(Exception)
            {
                throw;
            }
        }
    }
}
