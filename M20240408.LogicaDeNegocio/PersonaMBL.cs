using M20240408.EntidadesDeNegocio;
using M20240408AccesoADatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M20240408.LogicaDeNegocio
{
    public class PersonaMBL
    {
        readonly PersonaMDAL _personaMBL;

        public PersonaMBL(PersonaMDAL personaDAL)
        {
            _personaMBL = personaDAL;
        }
        public async Task<int> Crear(PersonaM personaM)
        {
            return await _personaMBL.Crear(personaM);
        }
        public async Task<int> Modificar(PersonaM personaM)
        {
            return await _personaMBL.Modificar(personaM);
        }
        public async Task<int> Eliminar(PersonaM personaM)
        {
            return await _personaMBL.Eliminar(personaM);
        }
        public async Task<PersonaM> ObtenerPoId(PersonaM personaM)
        {
            return await _personaMBL.ObtenerPoId(personaM);
        }
        public async Task<List<PersonaM>> ObtenerTodos()
        {
            return await _personaMBL.ObtenerTodos();
        }
        public async Task<List<PersonaM>> Buscar(PersonaM personaM)
        {
            return await _personaMBL.Buscar(personaM);
        }
    }
}
