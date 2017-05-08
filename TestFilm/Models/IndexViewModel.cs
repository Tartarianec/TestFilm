using System.Collections.Generic;

namespace TestFilm.Models
{
    public class IndexViewModel
    {
        public IEnumerable<Film> Films { get; set; }
        public PageViewModel PageViewModel { get; set; }
    }
}