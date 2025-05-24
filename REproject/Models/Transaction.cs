using System;
using System.Collections.Generic;

namespace REproject.Models;

public partial class Transaction
{
    public int TransactionId { get; set; }

    public int BookingId { get; set; }

    public decimal Amount { get; set; }

    public string PaymentMethod { get; set; } = null!;

    public string? PaymentStatus { get; set; }

    public DateTime? TransactionDate { get; set; }

    public virtual Booking Booking { get; set; } = null!;
}
