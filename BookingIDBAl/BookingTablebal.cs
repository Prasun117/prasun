using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conference_BookingBAl
{
    public class BookingTablebal
    {
        public int BookingID { get; set; }
        public int EmployeeID { get; set; }
        public int RoomID { get; set; }
        public DateTime BookingDate { get; set; }
        public TimeSpan StartTime { get; set; }
        public DateTime EndDate { get; set; }
        public TimeSpan EndTime { get; set; }
        public string Location { get; set; }
        public string BookingStatus { get; set; }



    }

   







}
