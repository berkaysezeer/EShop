using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entities
{
    public abstract class BaseEntity //abs olunca new yapilamaz
    {
        public virtual int Id { get; set; }
    }
}
