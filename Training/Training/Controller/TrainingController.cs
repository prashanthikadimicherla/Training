using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using Training.Model;
using Training.Service;

namespace Training.Controller
{
    [RoutePrefix("api/training")]
    public class TrainingController : ApiController
    {
        private ITrainingService _trainingService;
        public TrainingController(ITrainingService trainingService)
        {
            _trainingService = trainingService;
        }

        [Route("add")]  
        [HttpPost]
        public HttpResponseMessage AddTraining(TrainingModel trainingModel)
        {
            try
            {
                var errors = new List<string>();
                //Display validation errors
                if (!ModelState.IsValid)
                {
                    foreach (var state in ModelState)
                    {
                        foreach (var error in state.Value.Errors)
                        {
                            errors.Add(error.ErrorMessage);
                        }
                    }
                    return Request.CreateResponse(HttpStatusCode.BadRequest, errors);
                    
                }
                //Call service to insert record
                _trainingService.AddTrainingDetails(trainingModel);

                return Request.CreateResponse(HttpStatusCode.NoContent);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
        }
  
    }
}