using SEDC.CSharpAdv.VideoRental.Data.BaseMoels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.VideoRental.Data.Models
{
    public class User : BaseEntity
    {
        public string FullName { get; set; }
        public int CardNumber { get; set; }
        public DateTime DateoOfBirth { get; set; }
        public bool IsSubscriptionExpierd { get; set; }
        public DateTime SubscriptionExpireTime { get; set; }
         
    }
}
 