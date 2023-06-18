using Microsoft.EntityFrameworkCore;

namespace UniversityApiBackend.DataAccess
{
    public class UniversityDBContext: DbContext
    {
        public UniversityDBContext(DbContextOptions<UniversityDBContext> options): base(options) 
        {

        }

        //  TODO: Add DbSets (Tablas de la base de datos)
    }
}
