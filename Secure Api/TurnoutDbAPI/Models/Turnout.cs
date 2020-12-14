using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnoutDbAPI.Models
{
    public class Turnout
    {
        [Key]
        public string state_id { get; set; }
        public string state { get; set; }
        public string Official_Unofficial { get; set; }
        public double Total_Ballots_Counted_Estimate { get; set; }
        public Nullable<double> Vote_for_Highest_Office_President { get; set; }
        public string VEP_Turnout_Rate { get; set; }
        public double Voting_Eligible_Population_VEP { get; set; }
        public double Voting_Age_Population_VAP { get; set; }
        public string Non_citizen { get; set; }
        public string Prison { get; set; }
        public string Probation { get; set; }
        public string Parole { get; set; }
        public string Total_Ineligible_Felon { get; set; }
        public string Overseas_Eligible { get; set; }
    }
}
