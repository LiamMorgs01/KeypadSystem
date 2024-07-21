﻿using System;
using System.Collections.Generic;

namespace DataAccessLibrary.Models;

public partial class Customer
{
    public Guid CustomerId { get; set; }

    public int CustomerCode { get; set; }

    public Guid CompanyId { get; set; }

    public string CustomerFirstName { get; set; } = null!;

    public string CustomerLastName { get; set; } = null!;

    public DateTime CustomerDob { get; set; }

    public DateTime JoinedDate { get; set; }

}