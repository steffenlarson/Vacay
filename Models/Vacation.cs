using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Vacay.Models
{
  public abstract class Vacation
  {
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    public string Description { get; set; }
    public float Price { get; set; }
    // public float Distance { get; set; }

  }
}