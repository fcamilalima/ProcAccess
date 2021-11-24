using ProcAccess.Context;
using ProcAccess.Models;

namespace ProcAccess.Repositories
{
    public class ProcessoRepository : IProcessoRepository
    {
        private readonly AppDbContext _context;
        public ProcessoRepository(AppDbContext context)
        {
            _context = context; 
        }
        public IEnumerable<Processo> Processos => _context.Processos;

        public Processo GetProcessoById(int processoById)
        {
            //_context.Processos.FirstOrDefault(x => x.ProcessoId == processoById);
        }
    }
}
