using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace textLinesToObjects.Models
{
    public class spreadspoke_scores
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //schedule_date,schedule_season,schedule_week,schedule_playoff,team_home,score_home,score_away,team_away,team_favorite_id,spread_favorite,over_under_line,stadium,stadium_neutral,weather_temperature,weather_wind_mph,weather_humidity,weather_detail
        //9/2/1966,1966,1,FALSE,Miami Dolphins,14,23,Oakland Raiders,,,,Orange Bowl,FALSE,83,6,71,

        public int Id { get; set; } //### if this primary key is not added, there will be an error when adding records (to the dbcontext - dataset )
                                    // ## [MaxLength(4)] for sql server

  
        [Column(TypeName = "varchar(20)")] //### for mysql
        public string schedule_date { get; set; }
  
        [Column(TypeName = "varchar(20)")] //### for mysql
        public string schedule_season { get; set; }
        //[MaxLength(4)]
        [Column(TypeName = "varchar(4)")] //### for mysql


        public string schedule_week { get; set; }
        //[MaxLength(4)]
        [Column(TypeName = "varchar(20)")] //### for mysql


        public string schedule_playoff { get; set; }
        //[MaxLength(4)]
        [Column(TypeName = "varchar(20)")] //### for mysql

        public string team_home { get; set; }

        //[MaxLength(4)]
        [Column(TypeName = "varchar(20)")]
        public string score_home { get; set; }
        //[MaxLength(4)]

        [Column(TypeName = "varchar(20)")]
        public string score_away { get; set; }
        //[MaxLength(4)]
        //schedule_date,schedule_season,schedule_week,schedule_playoff,team_home,score_home,score_away,team_away,team_favorite_id,spread_favorite,over_under_line,stadium,stadium_neutral,weather_temperature,weather_wind_mph,weather_humidity,weather_detail
        //spread_favorite,over_under_line,stadium,stadium_neutral,weather_temperature,weather_wind_mph,weather_humidity,weather_detail

        [Column(TypeName = "varchar(20)")]
        public string team_away { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string startingPos { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string team_favorite_id { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string spread_favorite { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string over_under_line { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string stadium { get; set; }
        [Column(TypeName = "varchar(30)")]
        public string stadium_neutral { get; set; }
        [Column(TypeName = "varchar(10)")]
        public string weather_temperature { get; set; }
        [Column(TypeName = "varchar(10)")]
        public string weather_wind_mph { get; set; }
        [Column(TypeName = "varchar(10)")]
        public string weather_humidity { get; set; }
        [Column(TypeName = "varchar()")]
        public string weather_detail { get; set; }
       
        
    }
}
