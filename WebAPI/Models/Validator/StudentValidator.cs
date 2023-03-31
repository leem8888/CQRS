using FluentValidation;

namespace MediatrEx.Models.Validator
{
    public class StudentValidator : AbstractValidator<StudentAdd>
    {
        public StudentValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("FirstName is required")
                .MinimumLength(2).WithMessage("FirstName is at least 2 characters")
                .MaximumLength(6).WithMessage("FirstName is at max 6 characters");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("LastName is required")
                .MinimumLength(2).WithMessage("LastName is at least 2 characters")
                 .MaximumLength(6).WithMessage("LastName is at max 6 characters");
        }
    }   //ádfasd sdfasdf 
    //a//ádfasdfasdf

}  
