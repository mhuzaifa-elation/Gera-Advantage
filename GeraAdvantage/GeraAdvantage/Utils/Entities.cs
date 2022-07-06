using System;
using System.Collections.Generic;
using System.Text;

namespace GeraAdvantage.Utils
{
    internal class Entities
    {
        public enum Status { Pending, Sent_To_QA, Approved,Pending_For_NC_Closure };
        public class FilterDetail
        {
            public string Title { get; set; }
        }
        public class SampleChart
        {
            public string Name { get; set; }
            public double Number { get; set; }
        }
        public class FilterType
        {
            public string Type { get; set; }
        }
        public class Project
        {
            public string Title { get; set; }
            public int TotalNCCount { get; set; }
            public int OpenNCCount { get; set; }
            public int ClosedNCCount { get; set; }
            public string Severity { get; set; }

        }
        public class StakeHolder
        {
            public string Name { get; set; }
            public string Designation { get; set; }
        }
        public class NCHistory
        {
            public string Status { get; set; }
            public string Comment { get; set; }
            public string UpdatedBy { get; set; }
            public string UpdatedAt { get; set; }

        }
        public class Checklist
        {
            public string Title { get; set; }
            public string Building { get; set; }
            public string Floor { get; set; }
            public string Category { get; set; }
            public string CreatedBy { get; set; }
            public string UpdatedBy { get; set; }
            public Status Cstatus { get; set; }
            public string ProjDate { get; set; }
            public string Deadline { get; set; }
            public bool IsPast { get; set; }

        }
    }
}
