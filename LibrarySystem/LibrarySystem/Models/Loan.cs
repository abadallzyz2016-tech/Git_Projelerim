using System;
using System.Collections.Generic;
using System.Text;

namespace LibrarySystem.Models
{
    internal class Loan
    {
        public int ID { get; set; }
        public Book book { get; set; }
        public Member member { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime ? returnDate { get; set; }

        public double Fine {  get; set; }
            
        
    }

}
