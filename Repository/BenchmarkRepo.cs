using AuditBenchmarkModule.Models;
using System;
using System.Collections.Generic;

namespace AuditBenchmarkModule.Repository
{
    public class BenchmarkRepo: IBenchmarkRepo
    {
        private static List<AuditBenchmark> AuditBenchmarkList = new List<AuditBenchmark>()
        {
            new AuditBenchmark
            {
                auditType="Internal",
                benchmarkNoAnswers=3
            },
            new AuditBenchmark
            {
                auditType="SOX",
                benchmarkNoAnswers=1
            }
        };
        public List<AuditBenchmark> GetNolist()
        {
            List<AuditBenchmark> listOfCriteria = new List<AuditBenchmark>();
            try
            {
                listOfCriteria = AuditBenchmarkList;
                return listOfCriteria;
            }
            catch (Exception e)
            {
                return null;
            }

        }
    }
}
