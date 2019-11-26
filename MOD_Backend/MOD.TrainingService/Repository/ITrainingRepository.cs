using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MOD.TrainingService.Models;

namespace MOD.TrainingService.Repository
{
   public interface ITrainingRepository
    {
        void Training_Add(Training item);

        void Training_Update(Training item);

        List<Training> CurrentTraining(String Mentor_ID);
        List<Training> CompleteTraining(String Mentor_ID);

        List<Training> UserCurrentTraining(String Mentor_ID);
        List<Training> UserCompleteTraining(String Mentor_ID);

        IEnumerable<Training> GetAll();
    }
}
