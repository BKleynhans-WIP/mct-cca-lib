using System;
using System.Collections.Generic;
using System.Text;

using CCALib_Testing.Interfaces;

namespace CCALib_Testing.Models
{
    public class UasErrorReportEntry : IUasErrorReportEntry
    {
        public DateTime CurrentDate { get; set; } = DateTime.Now;
        public string MemberFirstName { get; set; }
        public string MemberLastName { get; set; }
        public string MedicaidNumber1 { get; set; }
        public string MedicaidNumber2 { get; set; }
        public string MedicaidNumber3 { get; set; }
        public DateTime AssessmentDate { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PerformingAgency { get; set; }
        public string EnrollingAgency { get; set; }
        public string Reason { get; set; }
    }
}
