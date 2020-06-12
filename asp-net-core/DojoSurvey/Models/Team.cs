using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace DojoSurvey.Models
{
    public class Team
    { 
        [Key]
        public long id { get; set; }
 
        [Required]
        public string name { get; set; }
 
        [Required]
        public string location { get; set; }
 
        public DateTime created_at { get; set; }
 
        public DateTime updated_at { get; set; }
 
        public IEnumerable<Player> players { get; set; }    // a given team may have many players
        
    	public Team() {
            players = new List<Player>();    
        }
    }
}
