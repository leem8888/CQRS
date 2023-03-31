using MediatrEx.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMediatR.TestData
{
    internal static class TestAddStudentDtoFactory
    {
        internal static StudentAdd StudentData()
        {
            return new StudentAdd
            {            
                FirstName = "bui",
                LastName = "tuan",
                Age = 18,
            };
        }
    }
}
