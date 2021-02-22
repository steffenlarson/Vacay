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



    // POST



    // PUT



    // DELETE





  }
}