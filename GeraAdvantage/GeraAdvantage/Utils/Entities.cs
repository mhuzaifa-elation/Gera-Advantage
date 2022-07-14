using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace GeraAdvantage.Utils
{
    internal class Entities
    {
        public enum Status { Pending, Sent_To_QA, Approved,Pending_For_NC_Closure };
        public class FilterDetail
        {
            public string Title { get; set; }
        }
        public class ConformityPie
        {
            public string Title { get; set; }
            public int Count { get; set; }
        }
        public class ReviewQ
        {

            public string Title { get; set; }
            public Color BGColor { get; set; }
            public string BtnText { get; set; }
        }
        public class MultileOps
        {
            public string Title { get; set; }
            public bool isfour { get; set; }
            public bool isthree { get; set; }
            public bool ConverttoNC { get; set; }
            public bool AddImage { get; set; }
            public bool SEComment { get; set; }
            public bool btnYes { get;  set; }
            public bool btnNo { get;  set; }
            public bool btnNA { get;  set; }
            public bool btnA { get;  set; }
            public bool btnAWC { get;  set; }
            public bool btnR { get; set; }
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
