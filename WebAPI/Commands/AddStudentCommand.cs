using MediatR;
using MediatrEx.Models;

namespace MediatrEx.Commands
{
    //Mỗi request (Query/Command) đều sẽ cần một handler cho chính nó
    //sẽ implements interface IRequest để thư viện MediatR biết
    // là class này là một query hay command.
    public record AddStudentCommand(StudentAdd Student) : IRequest<Student>;
}
