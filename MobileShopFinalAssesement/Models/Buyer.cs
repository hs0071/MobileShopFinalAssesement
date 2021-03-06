using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShopFinalAssesement.Models
{
    public class Buyer
    {
        [Key]
        public int Id { get; set; }
        //Name of the Buyer
        public string Buyer_Name { get; set; }
        //Address of the Buyer
        public string Buyer_Address { get; set; }
        //Contact number of the Buyer
        public string Buyer_Contact { get; set; }
        //Foreign Key
        //public int MobileID { get; set; }
        //public Mobile Mobile_obj { get; set; }
        //Foreign Key
        public int SellerID { get; set; }
        public Seller Seller_ID { get; set; }
    }
}
