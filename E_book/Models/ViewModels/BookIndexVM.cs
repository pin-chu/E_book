using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_book.Models.ViewModels
{
    public class BookIndexVM
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }
        public int PublishYear { get; set; }
    }
    public class BookVM
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }
        public string PublishYear { get; set; }
    }
}
