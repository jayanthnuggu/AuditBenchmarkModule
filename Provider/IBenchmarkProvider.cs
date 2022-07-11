using AuditBenchmarkModule.Models;
using System.Collections.Generic;

namespace AuditBenchmarkModule.Provider
{
    public interface IBenchmarkProvider
    {
        public List<AuditBenchmark> GetBenchmark();
    }
}
