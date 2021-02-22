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
      string sql = "SLECT * FROM flights;";
      return _db.Query<Flight>(sql);
    }

    // GETBYID



    // POST



    // PUT



    // DELETE





  }
}