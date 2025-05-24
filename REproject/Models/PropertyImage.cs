using System;
using System.Collections.Generic;

namespace REproject.Models;

public partial class PropertyImage
{
    public int ImageId { get; set; }

    public int PropertyId { get; set; }

    public string ImageUrl { get; set; } = null!;

    public bool? IsPrimary { get; set; }

    public DateTime? UploadedAt { get; set; }

    public virtual Property Property { get; set; } = null!;
}
