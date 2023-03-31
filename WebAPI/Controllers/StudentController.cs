using MediatR;
using MediatrEx.Commands;
using MediatrEx.Models;
using MediatrEx.Queries;
using Microsoft.AspNetCore.Mvc;

namespace MediatrEx.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IMediator _mediator;


        // controller sẽ không cần biết bất kỳ implement
        // mọi xử lý phức tạp đẵ được Mediator quản lý.
        public StudentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("GET")]
        public async Task<List<Student>> Get()
        {
            var model = new GetStudentListQuery();// khởi tạo request
            return await _mediator.Send(model);// call đến handle tương ứng của request
        }
        [HttpGet("GetById")]
        public async Task<Student> GetById(int id)
        {
            var model = new GetStudentByIdQuery(id);
            return await _mediator.Send(model);
        }

        [HttpPost("AddStudent")]
        public async Task<Student> Post([FromBody] StudentAdd value)
        {
            var model = new AddStudentCommand(value); 
            return await _mediator.Send(model);
        }
    }
}
