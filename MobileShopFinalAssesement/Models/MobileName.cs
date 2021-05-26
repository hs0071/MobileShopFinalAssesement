using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShopFinalAssesement.Models
{
    public class MobileName
    {

        [Key]
        //Mobile Id
        public int Id { get; set; }
        //Mobile Category
        public string Mobile_Category { get; set; }
    }
}
