using MediatrEx.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMediatR.TestData
{
    internal static class TestGetIdStudentDtoFactory
    {
      internal  static  Student StudentData()
        {
            return new Student
            {
                Id = 1,
                FirstName = "Test",
                LastName = "Doe",
                Age = 18,
            };
        }
    }
}
