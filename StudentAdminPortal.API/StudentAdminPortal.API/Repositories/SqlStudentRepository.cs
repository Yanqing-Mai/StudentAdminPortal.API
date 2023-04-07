using StudentAdminPortal.API.DataModels;
using Microsoft.EntityFrameworkCore;
namespace StudentAdminPortal.API.Repositories
{
    public class SqlStudentRepository : IStudentRepository
    {
        private readonly StudentAdminContext studentAdminCOntext;
        public SqlStudentRepository(StudentAdminContext studentAdminContext)
        {
            this.studentAdminCOntext = studentAdminContext;
        }
        public async Task<List<Student>> GetStudents()
        {
            return await studentAdminCOntext.Student.Include(nameof(Gender)).Include(nameof(Address)).ToListAsync();
        }
    }
}
