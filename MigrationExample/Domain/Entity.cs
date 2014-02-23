using System;
using Highway.Data;

namespace Domain
{
    public class Entity : IIdentifiable<long>
    {
        public long Id { get; set; }

        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
        
             
    }
}