using System;
using System.Collections.Generic;

namespace DataAccessLibrary.Models;

public partial class Company
{
    public Guid CompanyId { get; set; }

    public string CompanyName { get; set; } = null!;

    public string CompanyDescription { get; set; } = null!;

    public string? CompanyLogo { get; set; }

    public string CompanyUserName { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? CompanyColor { get; set; }

    //public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();
}
