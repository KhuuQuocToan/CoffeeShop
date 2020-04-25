using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop.Domain.Entities
{
    public class StaffEntity
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string StaffCode { get; set; }
        public string Email { get; set; }
        public string CreatedByUserId { get; set; }
        public string LastUpdatedByUserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public int IsDeleted { get; set; }
        public int Status { get; set; }
    }
}
