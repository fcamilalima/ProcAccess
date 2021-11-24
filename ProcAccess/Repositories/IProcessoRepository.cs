using ProcAccess.Models;

namespace ProcAccess.Repositories
{
    public interface IProcessoRepository
    {
        IEnumerable<Processo> Processos { get; }
        Processo GetProcessoById(int processoById);
    }
}
