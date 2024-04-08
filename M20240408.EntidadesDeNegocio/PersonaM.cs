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
        [Required]
        [StringLength(60)]
        [Display(Name ="Emerson")]
        public string NombreM { get; set; }
        [Required]
        [StringLength(60)]
        [Display(Name = "Aguilar")]
        public string ApellidoM { get; set; }
        [Display(Name = "Fecha Nacimiento")]
        public DateTime FechaNacimientoM { get; set; }
        [Display(Name = "Sueldo")]
        public decimal SueldoM { get; set; }
        [Display(Name = "Status")]
        public byte StatusM { get; set; }

    }
}
