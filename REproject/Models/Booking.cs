using System;
using System.Collections.Generic;

namespace REproject.Models;

public partial class Booking
{
    public int BookingId { get; set; }

    public int PropertyId { get; set; }

    public int UserId { get; set; }

    public DateTime? BookingDate { get; set; }

    public string? Status { get; set; }

    public virtual Property Property { get; set; } = null!;

    public virtual ICollection<Transaction> Transactions { get; } = new List<Transaction>();

    public virtual User User { get; set; } = null!;
}
