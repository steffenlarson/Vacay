using System;
using System.Collections.Generic;
using System.Data;
using Vacay.Models;
using Dapper;


namespace Vacay.Repository
{
  public class FlightsRepository
  {

    public readonly IDbConnection _db;

    public FlightsRepository(IDbConnection db)
    {
      _db = db;
    }


    // GETALL

    public IEnumerable<Flight> getAll()
    {
      string sql = "SELECT * FROM flight;";
      return _db.Query<Flight>(sql);
    }

    // GETBYID



    // POST

    internal Flight Create(Flight newFlight)
    {
      string sql = @"
         INSERT INTO flight
         (name, price, description, landings)
         VALUES
         (@Name, @Price, @Description, @Landings);
         SELECT LAST_INSERT_ID();";
      int Id = _db.ExecuteScalar<int>(sql, newFlight);
      newFlight.Id = Id;
      return newFlight;
    }

    // PUT



    // DELETE





  }
}