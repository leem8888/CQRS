using MediatR;
using MediatrEx.Models;

namespace MediatrEx.Queries
{
    //Mỗi request (Query/Command) đều sẽ cần một handler cho chính nó
    //sẽ implements interface IRequest để thư viện MediatR biết là class này là một query hay command.
    public record GetStudentListQuery : IRequest<List<Student>>
    {
    }
}
