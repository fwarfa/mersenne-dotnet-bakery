using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using dotnet_bakery.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnet_bakery.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BakerController : ControllerBase
    {
        // _context is our Datbase "repository"
        // it is how we grab models from the database
        // See /Models/ApplicationContext.cs
        private readonly ApplicationContext _context;

        // Some fancy "Dependency Injection" going on here
        // to access our ApplicationContext object
        public BakerController(ApplicationContext context) {
            _context = context;
        }

        // GET /api/baker
        [HttpGet]
        public IEnumerable<Baker> GetList() {
            // Grab the bakers from
            // my ApplicationContext
            //
            // Auto-magically queries the DB
            // and returns all the bakers
            //
            // Look ma, no SQL!
            return _context.Bakers;
        }

        // GET /api/baker/:id
        [HttpGet("{id}")]
        public Baker GetById(int id) {
            return _context.Bakers
                .SingleOrDefault(baker => baker.id == id);
        }

    }


}
