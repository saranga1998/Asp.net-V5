using System;
using System.ComponentModel.DataAnnotations;

namespace MyMvcApp.Models
{

    public class CustomerModel
    {

        [Required(ErrorMessage = "Nic Required")]
        public string NIC { get; set; }

        [Required(ErrorMessage = "Customer Name Required")]
        public string CustomerName { get; set; }

        [Required(ErrorMessage = "Address Required")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Contact No Required")]
        public int ContactNo { get; set; }
    }

}