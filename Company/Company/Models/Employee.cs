using System;
using System.Collections.Generic;

namespace Company.models;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string? EmployeeName { get; set; }

    public string? Department { get; set; }

    public string? Location { get; set; }
}
