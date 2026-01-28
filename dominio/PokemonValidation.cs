using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace dominio
{
    public class PokemonValidation : AbstractValidator<Pokemon>
    {
        public PokemonValidation()
        {
            RuleFor(x => x.numero)
                .NotEmpty().WithMessage("Complete");
            RuleFor(x => x.nombre)
                .NotEmpty().WithMessage("Complete")
                .Matches("^[a-zA-Z]+").WithMessage("Solo letras");
            RuleFor(x => x.descripcion)
                .NotEmpty().WithMessage("Complete")
                .Length(6, 150).WithMessage("Rango de 6-150 caracteres");
        }
    } 
}
