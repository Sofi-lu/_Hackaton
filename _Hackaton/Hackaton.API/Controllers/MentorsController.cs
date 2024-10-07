using Hackaton.API.Data;
using Microsoft.AspNetCore.Mvc;

namespace Hackaton.API.Controllers
{

    [ApiController]
    [Route("/api/mentors")]
    public class MentorsController: ControllerBase
    {
        private readonly DataContext _context;
        public MentorsController(DataContext context)
        {
            _context = context;


        }
    }
}
