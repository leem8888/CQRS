using MediatR;
using MediatrEx.Models;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System.Collections.Generic;
using TestMediatR.Extendsions;
using TestMediatR.TestData;
using Xunit;
using static Xunit.Assert;


namespace TestMediatR.Controllers
{
    public class StudenTest : IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly WebApplicationFactory<Program> _factory;
        public StudenTest(WebApplicationFactory<Program> factory)
        {
            _factory = factory;
        }
        [Fact]
        public async Task GetAllStudent_NoParameter_ListStudent()
        {
            var client = _factory.CreateClient();

            var response = await client.DoGetAsync<List<Student>>("/api/Student/GET");

            True(response.Count > 1);
        }

        [Fact]
        public async Task GetStudent_Id_StudentObject()
        {
            var dataTest = TestGetIdStudentDtoFactory.StudentData();

            var client = _factory.CreateClient();

            var response = await client.DoGetAsync<Student>("/api/Student/GetById?id=" + dataTest.Id);

            Equal(dataTest.Id, response.Id);
            Equal(dataTest.LastName, response.LastName);
            Equal(dataTest.Age, response.Age);
        }


        [Fact]
        public async Task AddStudent_StudentObject_Success()
        {
            var dataTest = TestAddStudentDtoFactory.StudentData();
             var client = _factory.CreateClient();
            var response = await client.DoPostAsync<Student>("/api/Student/AddStudent", dataTest);

            Equal(dataTest.FirstName, response.Data.FirstName);
            Equal(dataTest.LastName, response.Data.LastName);
            Equal(dataTest.Age, response.Data.Age);
            True(response.Success);
        }
    }
}