using Ardalis.Result;
using Bacteria.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bacteria.Core.Interfaces
{
    public interface IBacLibraryService
    {
        Task<ExperimentResult> GetExperimentResult(int experimentId);
    }
}
