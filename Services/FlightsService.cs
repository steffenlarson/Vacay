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
      return _repo.getAll();
    }

    // GETBYID
    internal Flight getById(int id)
    {
      Flight flight = _repo.getById(id);
      if (flight == null)
      {
        throw new Exception("invalid Id");
      }
      return flight;
    }


    // POST

    internal Flight Create(Flight newFlight)
    {
      return _repo.Create(newFlight);
    }

    // PUT
    internal Flight Edit(Flight editFlight)
    {
      Flight original = getById(editFlight.Id);

      original.Name = editFlight.Name != null ? editFlight.Name : original.Name;
      original.Price = editFlight.Price > 0 ? editFlight.Price : original.Price;
      original.Description = editFlight.Description != null ? editFlight.Description : original.Description;
      original.Landings = editFlight.Landings != null ? editFlight.Landings : original.Landings;

      return _repo.Edit(original);
    }


    // DELETE
    internal Flight Delete(int id)
    {

      Flight flight = getById(id);
      _repo.Delete(flight);
      return flight;
    }



  }
}