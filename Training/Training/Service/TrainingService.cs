using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Training.AutoMapper;
using Training.DataAccess;
using Training.DataAccess.Model;
using Training.Model;

namespace Training.Service
{
    public class TrainingService : ITrainingService
    {
        private readonly TrainingContext _trainingContext;
        public TrainingService()
        {
            _trainingContext = new TrainingContext();
        }
        public void AddTrainingDetails(TrainingModel model)
        {
            //Auto mapper to map data between the two models.
            var trainingDetails =
                Mapper.Map<TrainingModel, TrainingDetails>(model);
            //Context to save data.
            _trainingContext.TrainingDetails.Add(trainingDetails);
            _trainingContext.SaveChanges();
        }
    }
}