using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class Transfer
    {
        public int TransferId { get; set; }
        public float Import { get; set; }

        public int ClientId { get; set; }
        public Client Client { get; set; }
    }
}
