using System;

namespace CleanArchitecture.Core.Entities
{
    public class BaseEntity
    {
        public Guid? Id { get; set; }
        public DateTime? CreatedDate { get; set; }
         public DateTime? UpdatedDate { get; set; }
    }
}
