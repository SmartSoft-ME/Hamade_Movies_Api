using Microsoft.AspNetCore.Mvc;
using Movies;

namespace Movies.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {
       

        private readonly ILogger<MovieController> _logger;

        public MovieController(ILogger<MovieController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        static void CreateMovie(int Id,string Name,string Genre,int Year) 
        {
            List <Movie> movies = new();
            var id = movies.Any() ? movies.Max(m => m.Id) + 1 : 1;
            Movie m =new Movie(id, Name, Genre, Year); 
            movies.Add(m);
          
        }
       /* [HttpPut]
        public IActionResult Update()*/
        

       
        
    }
}