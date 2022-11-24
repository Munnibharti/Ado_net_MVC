using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace FootBallLeagueManagement.Models
{
    public class FootBallLeague
    {

        [Key]
        public int Serial { get; set; }

        //[Required]
        //[RegularExpression("",ErrorMessage ="please enter number only")]
        public int MatchId   { get; set; }

        //[Required]
        public string TeamName1 { get; set; }

        //[Required]
        public string TeamName2 { get; set; }

        //[Required]
      //  [RegularExpression("Draw" + "Win", ErrorMessage = "Please Enter Draw and Win")]
        public string Status { get; set; }

        //[Required]
        public string WinningTeam { get; set; }

        public int Points { get; set; }


    }
}