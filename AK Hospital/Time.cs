using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AK_Hospital
{
   public class Time
    {
        public int _Id;
        static int _id;
        public DateTime Starts { get; set; }
        public DateTime Ends { get; set; }
        public Time()
        {
            _Id = ++_id;
        }
        public override string ToString()
        {
            return $"{_Id} : {Starts.ToShortTimeString()} - {Ends.ToShortTimeString()}";
        }
    }
}
