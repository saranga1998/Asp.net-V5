using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyMvcApp.Models
{
    public class CustomerBookModel
    {

        [Key]
        public string BorrowId { get; set; }

        public DateTime IssueDate { get; set; }

        public DateTime RecievedDate { get; set; }

        [ForeignKey("Book")]

        public string Id { get; set; }

        public BookModel Book { get; set; }

        [ForeignKey("Customer")]

        public string NIC { get; set; }

        public CustomerModel Customer { get; set; }

    }
}