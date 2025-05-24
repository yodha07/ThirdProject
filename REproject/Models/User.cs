using System;
using System.Collections.Generic;

namespace REproject.Models;

public partial class User
{
    public int UserId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    public string? PhoneNumber { get; set; }

    public string Role { get; set; } = null!;

    public string? ProfilePicture { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual ICollection<Appointment> Appointments { get; } = new List<Appointment>();

    public virtual ICollection<Booking> Bookings { get; } = new List<Booking>();

    public virtual ICollection<LeaseAgreement> LeaseAgreements { get; } = new List<LeaseAgreement>();

    public virtual ICollection<Property> Properties { get; } = new List<Property>();

    public virtual ICollection<Review> Reviews { get; } = new List<Review>();
}
