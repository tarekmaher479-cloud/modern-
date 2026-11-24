using System;

namespace LeaveRequestSystem
{
    public class LeaveRequest
    {
        public string EmployeeName { get; set; }
        public string LeaveType { get; set; }
        public int DurationDays { get; set; }
        public string Status { get; set; }
        public DateTime RequestDate { get; set; }

        // Constructor for new requests submitted by employees
        public LeaveRequest(string empName, string leaveType, int duration)
        {
            EmployeeName = empName;
            LeaveType = leaveType;
            DurationDays = duration;
            Status = "Under Review";
            RequestDate = DateTime.Now;
        }

        // Overloaded constructor for pre-loaded historical records
        public LeaveRequest(string empName, string leaveType, int duration, string status, DateTime requestDate)
        {
            EmployeeName = empName;
            LeaveType = leaveType;
            DurationDays = duration;
            Status = status;
            RequestDate = requestDate;
        }

        public string GetInfo()
        {
            return $"[{Status.ToUpper()}]  {EmployeeName}  |  {LeaveType} ({DurationDays} days)  •  {RequestDate:MMM dd, yyyy}";
        }
    }
}