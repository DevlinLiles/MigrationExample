using Highway.Data;

namespace Domain
{
    public class Entity : IIdentifiable<long>
    {
        public long Id { get; set; }
             
    }
}