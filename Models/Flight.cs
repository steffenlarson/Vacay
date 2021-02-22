using System;
using System.ComponentModel.DataAnnotations;

namespace Vacay.Models
{
  public class Flight : Vacation
  {
    public string Landings { get; set; }
  }
}