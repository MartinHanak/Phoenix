using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers 
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController: ControllerBase 
    {
        private readonly EntityDBContext _context;
        
        public TestController(EntityDBContext context) {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Test>> GetTests() 
        {
            return _context.Tests.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Test> GetTest(int id) 
        {
            var test = _context.Tests.Find(id);
            if(test == null) {
                return NotFound();
            }
            return test;
        }

        [HttpPost]
        public ActionResult<Test> CreateTest(Test test) 
        {
            if(test == null) {
                return BadRequest();
            }
            _context.Tests.Add(test);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetTest), new {id = test.Id}, test);
        }
    }
}