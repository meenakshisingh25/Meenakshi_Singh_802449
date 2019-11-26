using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MOD.TrainingService.Context;
using MOD.TrainingService.Models;

namespace MOD.TrainingService.Repository
{
    public class TrainingRepository : ITrainingRepository
    {
        private readonly TrainingServiceContext _context;

        public TrainingRepository(TrainingServiceContext context)
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

        public List<Training> CompleteTraining(string Mentor_ID)
        {
            try
            {
                var obj = _context.Trainings.Where(s => s.Mentor_ID == Mentor_ID && s.Training_status == "complete").ToList();
                return obj;
            }catch(Exception)
            {
                throw;
            }
        }

        public List<Training> CurrentTraining(string Mentor_ID)
        {
            try{
                var obj = _context.Trainings.Where(s => s.Mentor_ID == Mentor_ID && s.Training_status == "current").ToList();
                return obj;
            }
            catch(Exception)
            {
                throw;
            }
        }

        public List<Training> UserCompleteTraining(string User_ID)
        {
            try
            {
                var obj = _context.Trainings.Where(s => s.User_ID == User_ID && s.Training_status == "complete").ToList();
                return obj;
            }
            catch
            {
                throw;
            }
        }

        public List<Training> UserCurrentTraining(string User_ID)
        {
            try
            {
                var obj = _context.Trainings.Where(s => s.User_ID == User_ID && s.Training_status == "current").ToList();
                return obj;
            }
            catch
            {
                throw;
            }
        }

        public IEnumerable<Training> GetAll()
        {
            try
            {
                return _context.Trainings.ToList();
            }
            catch(Exception)
            {
                throw;
            }
        }

        public void Training_Add(Training item)
        {
            try
            {
                _context.Trainings.Add(item);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }

        }

        public void Training_Update(Training item)
        {
            try
            {
                _context.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
           
        }
    }
}
