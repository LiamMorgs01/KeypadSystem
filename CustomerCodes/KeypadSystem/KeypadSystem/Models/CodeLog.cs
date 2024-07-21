using System;
using System.Collections.Generic;

namespace KeypadSystem.Models;

public partial class CodeLog
{
    public Guid CodeLogId { get; set; }

    public Guid CustomerId { get; set; }

    public DateTime CodeUsedDate { get; set; }

    //public virtual Customer Customer { get; set; } = null!;
}
