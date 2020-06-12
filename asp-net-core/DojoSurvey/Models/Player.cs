using System;
using System.ComponentModel.DataAnnotations;
 
namespace DojoSurvey.Models
{
    public class Player
    {
        [Key]
        public long id { get; set; }
 
        [Required]
        public string name { get; set; }
 
        [Required]
        public string skill { get; set; }
 
        public DateTime created_at { get; set; }
 
        public DateTime updated_at { get; set; }
    
    	public int team_id { get; set; }    // the foreign key value for the associated team (will be saved in db)
 
        public Team team { get; set; }      // a given player will be associated with a specific Team
        // while the Player model isn't saved with a whole team object in the db, 
        // having this object makes it much easier to interact with the Player instance in the rest of our code
    }
}
