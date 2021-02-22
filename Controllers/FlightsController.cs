using System;
using System.Collections.Generic;
using Vacay.Models;
using Vacay.Services;
using Microsoft.AspNetCore.Mvc;

namespace Vacay.Controllers
{

  [ApiController]
  [Route("api/[controller]")]
  public class FlightsController : ControllerBase
  {

    private readonly FlightsService _service;

    public FlightsController(FlightsService service)
    {
      _service = service;
    }


    // GETALL
    [HttpGet]
    public ActionResult<IEnumerable<Flight>> getAll()
    {
      try
      {
        return Ok(_service.getAll());
      }
      catch (Exception e)
      {

        return BadRequest(e.Message);
      }
    }


    // GETBYID
    [HttpGet("{id}")]
    public ActionResult<Flight> getByID(int id)
    {
      try
      {
        return Ok(_service.getById(id));
      }
      catch (Exception e)
      {

        return BadRequest(e.Message);
      }
    }

    // POST
    [HttpPost]

    public ActionResult<Flight> Create([FromBody] Flight newFlight)
    {
      try
      {
        return Ok(_service.Create(newFlight));
      }
      catch (Exception e)
      {

        return BadRequest(e.Message);
      }
    }

    // PUT
    [HttpPut("{id}")]
    public ActionResult<Flight> Edit([FromBody] Flight editFlight, int id)
    {
      try
      {
        editFlight.Id = id;
        return Ok(_service.Edit(editFlight));
      }
      catch (Exception e)
      {

        return BadRequest(e.Message);
      }
    }


    // DELETE





  }
}