using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Training.Controller;
using Training.Model;
using Training.Service;

namespace Training.Test
{
    [TestClass]
    public class TrainingControllerTest
    {
        public TrainingControllerTest()
        {

        }
        [TestMethod]
        public void AddTraining_TrainingNameEmpty()
        {
            var model = new TrainingModel
            {
                TrainingStartDate=DateTime.Now.ToString(),
                TrainingEndDate = DateTime.Now.AddYears(1).ToString()

            };
            var trainingServiceMock = new Mock<ITrainingService>();
            trainingServiceMock.Setup(service => service.AddTrainingDetails(model));

            var controller = new TrainingController(trainingServiceMock.Object);
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();
            controller.Validate(model); 

            var actualResult = controller.AddTraining(model);

            Assert.AreEqual(actualResult.StatusCode, HttpStatusCode.BadRequest);

        }

        [TestMethod]
        public void AddTraining_StartDateEmpty()
        {
            var model = new TrainingModel
            {
                TrainingName = ".net advanced",
                TrainingEndDate = DateTime.Now.AddYears(1).ToString(),
                
            };
            var trainingServiceMock = new Mock<ITrainingService>();
            trainingServiceMock.Setup(service => service.AddTrainingDetails(model));

            var controller = new TrainingController(trainingServiceMock.Object);
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();
            controller.Validate(model);

            var actualResult = controller.AddTraining(model);

            Assert.AreEqual(actualResult.StatusCode, HttpStatusCode.BadRequest);

        }

        [TestMethod]
        public void AddTraining_EndDateEmpty()
        {
            var model = new TrainingModel
            {
                TrainingName = ".net advanced",
                TrainingStartDate = DateTime.Now.ToString()

            };
            var trainingServiceMock = new Mock<ITrainingService>();
            trainingServiceMock.Setup(service => service.AddTrainingDetails(model));

            var controller = new TrainingController(trainingServiceMock.Object);
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();
            controller.Validate(model);

            var actualResult = controller.AddTraining(model);

            Assert.AreEqual(actualResult.StatusCode, HttpStatusCode.BadRequest);

        }

        [TestMethod]
        public void AddTraining_EndDateBeforeStartDate()
        {
            var model = new TrainingModel
            {
                TrainingName = ".net advanced",
                TrainingStartDate = DateTime.Now.ToString(),
                TrainingEndDate = DateTime.Now.AddYears(-1).ToString()

            };
            var trainingServiceMock = new Mock<ITrainingService>();
            trainingServiceMock.Setup(service => service.AddTrainingDetails(model));

            var controller = new TrainingController(trainingServiceMock.Object);
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();
            controller.Validate(model);

            var actualResult = controller.AddTraining(model);

            Assert.AreEqual(actualResult.StatusCode, HttpStatusCode.BadRequest);

        }

        [TestMethod]
        public void AddTraining_ValidationOk()
        {
            var model = new TrainingModel
            {
                TrainingName = ".net advanced",
                TrainingStartDate = DateTime.Now.ToString(),
                TrainingEndDate = DateTime.Now.AddYears(1).ToString()

            };
            var trainingServiceMock = new Mock<ITrainingService>();
            trainingServiceMock.Setup(service => service.AddTrainingDetails(model));

            var controller = new TrainingController(trainingServiceMock.Object);
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();
            controller.Validate(model);

            var actualResult = controller.AddTraining(model);

            Assert.AreEqual(actualResult.StatusCode, HttpStatusCode.NoContent);

        }
    }
}
