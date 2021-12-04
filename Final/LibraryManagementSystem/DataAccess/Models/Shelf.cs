using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Shelf
    {
        public int Id { get; set; }
        public int ShelfLevel { get; set; }
        public string ShelfLocation { get; set; }
    }
}
