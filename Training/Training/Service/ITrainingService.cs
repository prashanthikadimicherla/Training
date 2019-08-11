using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.Model;

namespace Training.Service
{
    public interface ITrainingService
    {
        void AddTrainingDetails(TrainingModel model);
    }
}
