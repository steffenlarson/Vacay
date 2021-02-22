using System;
using System.Collections.Generic;
using Vacay.Models;
using Vacay.Repository;

namespace Vacay.Services
{
  public class FlightsService
  {

    private readonly FlightsRepository _repo;

    public FlightsService(FlightsRepository repo)
    {
      _repo = repo;
    }



    // GETALL

    internal IEnumerable<Flight> getAll()
    {
      return _repo.getALl();
    }

    // GETBYID



    // POST



    // PUT



    // DELETE




  }
}