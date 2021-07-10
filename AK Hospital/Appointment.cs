using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AK_Hospital
{
    public  class Appointment
    {
        public string PatientName { get; set; }
        public Time Start { get; set; }
        public Time End { get; set; }
        public bool isFull { get; set; }
    }
}
