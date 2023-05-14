using KranumApiWeb.Controllers;
using KranumCore.ViewResource.Event;
using KranumDataAccess.Model;
using KranumDataAccess.Models;
using KranumDataAccess.Repository;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KranumTest.ControllerTests
{
    public  class EventControllerTests
    {
        private readonly RelyfyDotNetStagingContext _context;


        private EventControllerTestsDataValues _dataValues;

        public EventControllerTests()
        {
            _context ??= GetDatabaseContext();
        }

        private static RelyfyDotNetStagingContext GetDatabaseContext()
        {
            var options = new DbContextOptionsBuilder<RelyfyDotNetStagingContext>()
               .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
               .Options;
            var databaseContext = new RelyfyDotNetStagingContext(options);
            databaseContext.Database.EnsureCreated();
            return databaseContext;
        }

        [Fact]
        public async void Should_return_Ok_status_for_members_available()
        {
            // Arranged
            Mock<IMediator> _mockMediator;
            EventController _controller;

            var request = new CreateEventRequestViewResource();
           
            _mockMediator = new Mock<IMediator>();
            _mockMediator.Setup(x => x.Send(It.IsAny<CreateEventRequestViewResource>(),
            It.IsAny<CancellationToken>())).ReturnsAsync(Unit.Value);
            //      It.IsAny<CancellationToken>())).ReturnsAsync(System.Threading.Tasks.Task.FromResult(EventControllerTestsDataValues.GetEventDiscussion()));

            _controller = new EventController(_mockMediator.Object);

            // Act
            var result = await _controller.GetAllEvent();

            // Assert            
            int? code = ((Microsoft.AspNetCore.Mvc.ObjectResult)result.Result).StatusCode;
            Assert.Equal(200, code);
                 }


    }
}
