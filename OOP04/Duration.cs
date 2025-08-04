using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04
{
    using System;

    public class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public Duration() { }

        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        public override string ToString()
        {
            return $"{Hours}h {Minutes}m {Seconds}s";
        }

        public override bool Equals(object obj)
        {
            if (obj is Duration other)
            {
                return this.Hours == other.Hours &&
                       this.Minutes == other.Minutes &&
                       this.Seconds == other.Seconds;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Hours, Minutes, Seconds);
        }
    }

}
