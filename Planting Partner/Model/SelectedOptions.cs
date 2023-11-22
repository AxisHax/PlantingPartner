using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planting_Partner.Model
{
    public static class SelectedOptions
    {
        public static string season;
        public static string zone;

        public static void SetSeason(string selectedSeason)
        {
            season = selectedSeason;
        }

        public static void SetZone(string selectedZone)
        {
            zone = selectedZone;
        }
    }
}
