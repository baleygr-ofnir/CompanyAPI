using System;
using System.Collections.Generic;

namespace CompanyAPI.Models;

public partial class Company
{
    public int Id { get; set; }

    public string OrgNumber { get; set; } = null!;

    public string? Name { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    public string? Industry { get; set; }

    public string? Website { get; set; }

    public string? Tags { get; set; }

    public bool? IsBankrupt { get; set; }
}
