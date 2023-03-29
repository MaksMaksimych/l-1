using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        public sbyte Operand1 { get; set; }
        public sbyte Operand2 { get; set; }
        public string Operation { get; set; }
        public decimal Result { get; set; }
    }
}