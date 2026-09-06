using System;
using System.Collections.Generic;
using System.Text;

namespace LibrarySystem.Models
{
    internal class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public bool IsAvailable { get; set; }
        public string publicationYear { get; set; }
    }
}
