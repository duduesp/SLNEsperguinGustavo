using System.ComponentModel.DataAnnotations;

namespace SistemaWebMisRecetas.Validations
{
    public class CategoriaAttribute :ValidationAttribute
    {
        public CategoriaAttribute()
        {
            ErrorMessage = "La categoría debe ser 'Desayuno'";
        }

        public override bool IsValid(object value)
        {
            string categoria = (string)value;
            if (categoria.ToUpper() == "DESAYUNO")
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
