using System;
using System.Collections.Generic;

namespace REproject.Models;

public partial class Property
{
    public int PropertyId { get; set; }

    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public decimal Price { get; set; }

    public string Address { get; set; } = null!;

    public string? City { get; set; }

    public string? State { get; set; }

    public string? ZipCode { get; set; }

    public string PropertyType { get; set; } = null!;

    public string Status { get; set; } = null!;

    public int OwnerId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual ICollection<Appointment> Appointments { get; } = new List<Appointment>();

    public virtual ICollection<Booking> Bookings { get; } = new List<Booking>();

    public virtual ICollection<LeaseAgreement> LeaseAgreements { get; } = new List<LeaseAgreement>();

    public virtual User Owner { get; set; } = null!;

    public virtual ICollection<PropertyImage> PropertyImages { get; } = new List<PropertyImage>();

    public virtual ICollection<Review> Reviews { get; } = new List<Review>();
}
