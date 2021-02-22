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
    internal Flight getById(int id)
    {
      string sql = "SELECT * FROM flight WHERE id = @id;";
      // REVIEW Why do we make the id below an object???
      return _db.QueryFirstOrDefault<Flight>(sql, new { id });
    }


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
    internal Flight Edit(Flight original)
    {
      string sql = @"
          UPDATE flight
          SET
              name = @Name,
              price = @Price,
              description = @Description,
              landings = @Landings
          WHERE id = @Id;
          SELECT * FROM flight WHERE id = @Id;";
      return _db.QueryFirstOrDefault<Flight>(sql, original);
    }


    // DELETE

    internal void Delete(Flight flight)
    {
      string sql = "DELETE FROM flight WHERE id = @Id";
      _db.Execute(sql, flight);
    }



  }
}