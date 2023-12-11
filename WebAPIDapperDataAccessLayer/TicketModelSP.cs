using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIDapperDataAccessLayer
{
    public class TicketModelSP
    {
        public int PASSENGERID { get; set; }
        public long TICKETNUMBER { get; set; }
        public string PASSENGERNAME { get; set; }
        public long PHNUMBER { get; set; }
        public string EMAILID { get; set; }
        public DateTime JOURNEYDATE { get; set; }
    }
}
