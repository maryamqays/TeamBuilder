using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamBuilder.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string ArName { get; set; }
        public string EnName { get; set; }
        public int Pupulation { get; set; }
        public string CountryCode { get; set; }
    }
}
