using System;
using System.ComponentModel.DataAnnotations;

namespace Vacay.Models
{
  public class Cruise : Vacation
  {
    public string Port { get; set; }
  }
}