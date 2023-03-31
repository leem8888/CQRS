using MediatR;
using MediatrEx.DataAccess;
using MediatrEx.Models;
using MediatrEx.Queries;

namespace MediatrEx.Handles
{
    public class GetStudentByIdHandler : IRequestHandler<GetStudentByIdQuery, Student>
    {
        private readonly IDataAccess _data;
        public GetStudentByIdHandler(IDataAccess data)
        {
            _data = data;
        }
        public Task<Student> Handle(GetStudentByIdQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.GetStudentById(request.id));
        }
    }
}
