using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;

namespace modul10_103022300016.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private static List<Movie> listMovie = new List<Movie>
        {
            new Movie("The Shawshank Redemption", "Frank Darabont", new string[] { "Tim Robbins", "Morgan Freeman", "Bob Gunton" }, "A banker convicted of uxoricide forms a friendship over a quarter century with a hardened convict, while maintaining his innocence and trying to remain hopeful through simple compassion."),
            new Movie("The Godfather", "Francis Ford Coppola", new string[] { "Marlon Brando", "Al Pacino", "James Caan" }, "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son."),
            new Movie("The Dark Knight", "Christopher Nolan", new string[] { "Christian Bale", "Heath Ledger", "Aaron Eckhart" }, "When the menace known as the Joker emerges from his mysterious past, he wreaks havoc and chaos on the people of Gotham. The Dark Knight must accept one of the greatest psychological and physical tests of his ability to fight injustice.")
        };

        // GET: api/Movie : Mengembalikan output isi listMovie
        [HttpGet]
        public ActionResult<List<Movie>> GetAll()
        {
            // Mengembalikan output isi listMovie
            return listMovie;
        }

        // GET: api/Movie/{index} : Mengembalikan output isi listMovie dengan index yang diinputkan
        [HttpGet("{id}")]
        public ActionResult<Movie> GetByIndex(int id)
        {
            if (id < 0 || id >= listMovie.Count)
            {
                // Jika index yang diinputkan tidak valid, maka mengembalikan NotFound
                return NotFound();
            }
            // Mengembalikan output isi listMovie dengan index yang diinputkan
            return listMovie[id];
        }

        // POST: api/Movie : Menambah data film baru ke dalam listMovie
        [HttpPost]
        public ActionResult<List<Movie>> Create(Movie movie)
        {
            // Menambahkan data film pada list
            listMovie.Add(movie);
            // Mengembalikan output isi listMovie
            return listMovie;
        }

        // DELETE : api/Movie/{index} : Menghapus data film pada listMovie sesuai index yang diinputkan
        [HttpDelete("{id}")]
        public ActionResult<List<Movie>> Delete(int id)
        {
            if (id < 0 || id >= listMovie.Count)
            {
                return NotFound();
            }
            // Menghapus data film pada listMovie sesuai index yang diinputkan
            listMovie.RemoveAt(id);
            // Mengembalikan output isi listMovie
            return listMovie;
        }
    }
}
