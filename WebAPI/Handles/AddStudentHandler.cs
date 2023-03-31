using MediatR;
using MediatrEx.Commands;
using MediatrEx.DataAccess;
using MediatrEx.Models;

namespace MediatrEx.Handles
{
    public class AddStudentHandler : IRequestHandler<AddStudentCommand, Student>
    {
        private readonly IDataAccess _data;
        public AddStudentHandler(IDataAccess data)
        {
            _data = data;
        }
        public Task<Student> Handle(AddStudentCommand request, CancellationToken cancellationToken)
        {          
            return Task.FromResult(_data.AddStudent(request.Student));
        }
    }
}
