using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M20240408.EntidadesDeNegocio
{
    public class PersonaM
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
       
        [StringLength(60)]
        [Display(Name ="Emerson")]
        [Required(ErrorMessage ="El campo Nombre es Requerido")]
        public string NombreM { get; set; }
        [Required(ErrorMessage= "El campo Apellido es Requerido")]
        [StringLength(60)]
        [Display(Name = "Aguilar")]
        public string ApellidoM { get; set; }
        [Required(ErrorMessage= "El campo Fecha Nacimiento es Requerido")]
        [Display(Name = "Fecha Nacimiento")]
        public DateTime FechaNacimientoM { get; set; }
        [Display(Name = "Sueldo")]
        [Required(ErrorMessage = "El campo Sueldo es Requerido")]
        public decimal SueldoM { get; set; }
        [Display(Name = "Status")]
        [Required(ErrorMessage= "El campo Status es Requerido")]
        public byte StatusM { get; set; }

    }
}
