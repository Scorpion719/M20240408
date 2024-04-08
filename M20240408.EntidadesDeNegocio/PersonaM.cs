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
        public string NombreM { get; set; }
        [Required]
        [StringLength(60)]
        public string ApellidoM { get; set; }
        public DateTime FechaNacimientoM { get; set; }
        public decimal SueldoM { get; set; }
        public byte StatusM { get; set; }

    }
}
