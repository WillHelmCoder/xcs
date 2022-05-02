using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xcs.Models
{
    public class XipeCoinModel
    {
        public int Id { get; set; } 
        public Guid XipecoinPKey { get; set; }
        public DateTime CreationDate { get; set; }
        public int OriginalOwner { get; set; }
        public int Receiver { get; set; }
    }
}
