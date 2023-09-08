using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private ApplicationDbContext _context { get; }
        public CompanyController(ApplicationDbContext context)
        {

            _context = context;

        }


        // CRUD

        // Create

        // Read

        // Update

        // Delete
    }
}
