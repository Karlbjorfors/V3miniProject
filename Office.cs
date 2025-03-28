using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V3miniProject
{
    public class Office
    {
        public string OfficeName { get; set; }
        public string Currency { get; set; }
        public Office(string officeName, string currency)
        {
            OfficeName = officeName;
            Currency = currency;
        }
    }
}

