using System;
using System.Collections.Generic;
using System.Text;

using CCALib_Testing.Models;

namespace CCALib_Testing.Interfaces
{
    public interface IUasErrorReportEntry : IErrorReportEntry
    {
        DateTime CurrentDate { get; set; }
        string MemberFirstName { get; set; }
        string MemberLastName { get; set; }
        string MedicaidNumber1 { get; set; }
        string MedicaidNumber2 { get; set; }
        string MedicaidNumber3 { get; set; }
        DateTime AssessmentDate { get; set; }
        DateTime DateOfBirth { get; set; }
        string PerformingAgency { get; set; }
        string EnrollingAgency { get; set; }
        string Reason { get; set; }
    }
}
