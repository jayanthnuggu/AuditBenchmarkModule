using AuditBenchmarkModule.Models;
using AuditBenchmarkModule.Repository;
using System;
using System.Collections.Generic;

namespace AuditBenchmarkModule.Provider
{
    public class BenchmarkProvider: IBenchmarkProvider
    {
        private readonly IBenchmarkRepo objBenchmarkRepo;
        public BenchmarkProvider(IBenchmarkRepo _objBenchmarkRepo)
        {
            objBenchmarkRepo = _objBenchmarkRepo;
        }

        public List<AuditBenchmark> GetBenchmark()
        {

            List<AuditBenchmark> listOfRepository = new List<AuditBenchmark>();
            try
            {
                listOfRepository = objBenchmarkRepo.GetNolist();
                return listOfRepository;
            }
            catch (Exception e)
            {
                return null;
            }

        }
    }
}
