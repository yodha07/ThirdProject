using System;
using System.Collections.Generic;

namespace REproject.Models;

public partial class Appointment
{
    public int AppointmentId { get; set; }

    public int UserId { get; set; }

    public int PropertyId { get; set; }

    public DateTime AppointmentDate { get; set; }

    public string? Status { get; set; }

    public virtual Property Property { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
