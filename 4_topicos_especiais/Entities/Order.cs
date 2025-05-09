
using _4_topicos_especiais.enums;

namespace _4_topicos_especiais.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return $"{Id}, {Moment}, {Status} ";
        }

        
    }
}