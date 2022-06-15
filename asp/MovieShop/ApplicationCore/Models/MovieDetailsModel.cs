using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models
{
    public class MovieDetailsModel
    {
        // many many properties
        public int Id { get; set; }
        public string Title { get; set; }
        public string Posterurl { get; set; }
        public int Runtime { get; set; }
        public DateTime ReleaseTime { get; set; }
    }
}
