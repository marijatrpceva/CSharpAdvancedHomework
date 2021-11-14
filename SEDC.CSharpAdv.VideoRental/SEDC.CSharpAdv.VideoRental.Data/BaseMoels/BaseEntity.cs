using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.VideoRental.Data.BaseMoels
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public BaseEntity()
        {
            CreatedOn = DateTime.Now;
        }
    }
}
