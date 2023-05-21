using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektOOP.Models
{
    public class Attendance : IComparable<Attendance>
    {

        public String venue { get; set; }
        public long attendance { get; set; }

        public String home_team_country { get; set; }
        public String away_team_country { get; set; }

        public int CompareTo(Attendance obj)
        {
            return -this.attendance.CompareTo(obj.attendance);
        }
        public override string ToString()
        {
            return $"{home_team_country} vs {away_team_country}";
        }

    }
}
