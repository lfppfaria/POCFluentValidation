using FluentValidation;
using POCFluentValidation.Model;
using System;
using System.Linq;

namespace POCFluentValidation.Validators
{
    public class PersonValidator : AbstractValidator<Person>
    {
        public PersonValidator()
        {
            RuleFor(person => person.Name)
                .NotEmpty().WithMessage("Nome não pode ser vazio.")
                .Must(IsValidName).WithMessage("Nome deve ser composto somente de letras.");

            RuleFor(person => person.Email)
                .NotEmpty().WithMessage("Email não pode ser vazio.")
                .EmailAddress().WithMessage("Endereço de email informado não é um endereço válido.");

            RuleFor(person => person.BirthDate)
                .NotEmpty().WithMessage("Data de nascimento deve ser informada.")
                .LessThan(DateTime.Now).WithMessage("Data de nascimento não pode ser superior a data atual");
        }

        private bool IsValidName(string name)
        {
            if (string.IsNullOrEmpty(name))
                return true;

            return !name.All(Char.IsDigit);
        }
    }
}
