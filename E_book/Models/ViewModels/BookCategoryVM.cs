using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_book.Models.ViewModels
{
    public class BookCategoryIndexVM
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string FictionName { get; set; }
        public int DisplayOrder { get; set; }
        public int FictionId { get; set; }
    }
    public class BookCategoryVM
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public int DisplayOrder { get; set; }
    }
    public class FictionCategoryVM
    {
        public int Id { get; set; }
        public string FictionName { get; set; }
        public int DisplayOrder { get; set; }
        public int FictionId { get; set; }
    }

}
