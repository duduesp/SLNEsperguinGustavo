using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using SistemaWebMisRecetas.Validations;

namespace SistemaWebMisRecetas.Models
{
    public class Receta
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obligatorio.")]
        [Column(TypeName = "varchar(50)")]
        [StringLength(50)] 
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Campo obligatorio.")]
        [CategoriaAttribute]
        [Column(TypeName = "varchar(50)")]
        [StringLength(50)] 
        public string Categoria { get; set; }

        [Required(ErrorMessage = "Campo obligatorio.")]
        [DataType(DataType.MultilineText)]
        [Column(TypeName = "varchar(200)")]
        [StringLength(200)] 
        public string Ingredientes { get; set; }

        [Required(ErrorMessage = "Campo obligatorio.")]
        [DataType(DataType.MultilineText)]
        [Column(TypeName = "varchar(200)")]
        [StringLength(200)] 
        public string Instrucciones { get; set; }

        [Required(ErrorMessage = "Campo obligatorio.")]
        [Column(TypeName = "varchar(50)")]
        [StringLength(50)] 
        public string NombreAutor { get; set; }

        [Required(ErrorMessage = "Campo obligatorio.")]
        [Column(TypeName = "varchar(50)")]
        [StringLength(50)] 
        public string ApellidoAutor { get; set; }

        [Required(ErrorMessage = "Campo obligatorio.")]
        [EdadAttribute]
        public int EdadAutor { get; set; }

        [Required(ErrorMessage = "Campo obligatorio.")]
        [Column(TypeName = "varchar(50)")]
        [StringLength(50)] 
        public string EmailAutor { get; set; }



    }
}
