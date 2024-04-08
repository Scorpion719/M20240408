using M20240408.EntidadesDeNegocio;
using Microsoft.EntityFrameworkCore;

namespace M20240408AccesoADatos
{
    public class PersonaMDAL
    {
        readonly AppDbContext _appDbContext;
        public PersonaMDAL(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<int> Crear(PersonaM personaM)
        {
            _appDbContext.Add(personaM);
            return await _appDbContext.SaveChangesAsync();
        }
        public async Task<int> Modificar(PersonaM personaM)
        {
            var PersonaData = await _appDbContext.Persona.FirstOrDefaultAsync(s => s.Id == personaM.Id);
            if (PersonaData != null)
            {
                PersonaData.NombreM = personaM.NombreM;
                PersonaData.ApellidoM = personaM.ApellidoM;
                PersonaData.FechaNacimientoM = personaM.FechaNacimientoM;
                PersonaData.SueldoM = personaM.SueldoM;
                PersonaData.StatusM = personaM.StatusM;
                _appDbContext.Update(PersonaData);
            }
            return await _appDbContext.SaveChangesAsync();
        }
        public async Task<int> Eliminar(PersonaM personaM)
        {
            var PersonaData = await _appDbContext.Persona.FirstOrDefaultAsync(s => s.Id == personaM.Id);
            if (PersonaData != null)
                _appDbContext.Remove(PersonaData);
            return await _appDbContext.SaveChangesAsync();
        }
        public async Task<PersonaM> ObtenerPoId(PersonaM personaM)
        {
            var PersonaData = await _appDbContext.Persona.FirstOrDefaultAsync(s => s.Id == personaM.Id);
            if (PersonaData != null)
                return PersonaData;
            else
                return new PersonaM();
        }
        public async Task<List<PersonaM>> ObtenerTodos()
        {
            return await _appDbContext.Persona.ToListAsync();
        }
        public async Task<List<PersonaM>> Buscar(PersonaM personaM)
        {
            var query = _appDbContext.Persona.AsQueryable();
            if (!string.IsNullOrWhiteSpace(personaM.NombreM))
            {
                query = query.Where(s => s.NombreM.Contains(personaM.NombreM));
            }
            if (!string.IsNullOrWhiteSpace(personaM.ApellidoM))
            {
                query = query.Where(s => s.NombreM.Contains(personaM.ApellidoM));
            }
            return await query.ToListAsync();
        }
    }
}
