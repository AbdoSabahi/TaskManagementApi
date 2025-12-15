using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using TaskManagementApi.Data;
using TaskManagementApi.Entities;

namespace TaskManagementApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TasksController(ApplicationDbContext context)
        {
            _context = context;
        }


       


        [HttpGet]
        public IActionResult GetAll(string? status)
        {
            var tasks = _context.Tasks.AsQueryable();

            if (!string.IsNullOrEmpty(status))
            {
                tasks = tasks.Where(t => t.Status == status);
            }

            return Ok(tasks.ToList());
        }

        [HttpPost]
        public IActionResult Create(TaskItem task)
        {
            _context.Tasks.Add(task);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetAll), new { id = task.Id }, task);
        }


        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            var task = _context.Tasks.Find(id);

            if (task == null)
                return NotFound();

            _context.Tasks.Remove(task);
            _context.SaveChanges();

            return NoContent();
        }


    }
}
