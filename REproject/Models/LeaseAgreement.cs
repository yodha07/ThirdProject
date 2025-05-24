using System;
using System.Collections.Generic;

namespace REproject.Models;

public partial class LeaseAgreement
{
    public int LeaseId { get; set; }

    public int PropertyId { get; set; }

    public int TenantId { get; set; }

    public DateTime LeaseStartDate { get; set; }

    public DateTime LeaseEndDate { get; set; }

    public decimal RentAmount { get; set; }

    public decimal SecurityDeposit { get; set; }

    public virtual Property Property { get; set; } = null!;

    public virtual User Tenant { get; set; } = null!;
}
