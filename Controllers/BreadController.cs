using System.Net.NetworkInformation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using dotnet_bakery.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnet_bakery.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BreadController : ControllerBase
    {
        private readonly ApplicationContext _context;
        public BreadController(ApplicationContext context) {
            _context = context;
        }

        // GET /api/bread
        [HttpGet]
        public IEnumerable<Bread> GetList() {
            return _context.Breads
                .Include(bread => bread.bakedBy);
        }

        // GET /api/bread/:id
        [HttpGet("{id}")]
        public Bread GetById(int id) {
            return _context.Breads
                .Include(bread => bread.bakedBy)
                .SingleOrDefault(b => b.id == id);
        }

        // POST /api/bread
        [HttpPost]
        public Bread Post(Bread bread) {
            bread.description = "[REDACTED]";

            _context.Add(bread);
            _context.SaveChanges();

            return bread;
        }

        // PUT /api/bread/:id
        [HttpPut("{id}")]
        public Bread Put(int id, Bread bread) {
            //var existingBread = _context.Breads.Find(id);
            //_context.Entry(existingBread).CurrentValues.SetValues(bread);
            //_context.Breads.AddOrUpdate(bread);

            _context.Breads.Attach(bread);

            // updates the bread in our context
            //_context.Entry(bread).State = EntityState.Modified;
            _context.SaveChanges();

            return bread;
        }

        [HttpDelete("{id}")]
        public void Delete(int id) {
            Bread bread = _context.Breads.Find(id);

            _context.Breads.Remove(bread);
            _context.SaveChanges();
        }
    }
}
