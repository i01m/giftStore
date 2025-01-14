using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;


namespace GiftsForEveryone.Models
{
    public class Order
    {
        [BindNever] //prevents user from suppliying values for these fields in the http request
                    //stops mvc using values from http request to populate sensetive model properties
        public int OrderID { get; set; }
        [BindNever]
        public ICollection<CartLine> Lines { get; set; }
        [BindNever]
        public bool Shipped { get; set; }

        [Required(ErrorMessage = "Please enter a name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter the first address line")]
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }

        [Required(ErrorMessage ="Please enter a city")]
        public string City { get; set; }

        [Required(ErrorMessage ="Please enter a state")]
        public string State { get; set; }

        public int Zip { get; set; }

        [Required(ErrorMessage ="Please enter a country")]
        public string Country { get; set; }

        public bool GiftWrap { get; set; }
    }
}
