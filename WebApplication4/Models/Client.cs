using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class Client
    {
        public int ClientId { set; get; }
        public string Name { get; set; }
        public string Telephone { get; set; }
        public ICollection<Transfer> Transfers { get; set; }
    }
}