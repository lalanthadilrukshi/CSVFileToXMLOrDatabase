using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace textLinesToObjects.Models
{
    public class HomeGames
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //year.key,league.key,team.key,park.key,span.first,span.last,games,openings,attendance
        //1871,NA,BS1,BOS01,1871-05-16,1871-10-07,16,16,32600
        public int Id { get; set; } //### if this primary key is not added, there will be an error when adding records (to the dbcontext - dataset )
                                    // ## [MaxLength(4)] for sql server

    
        [Column(TypeName = "varchar(4)")] //### for mysql
        public string year_key { get; set; }
    
        [Column(TypeName = "varchar(4)")] //### for mysql
        public string league_key { get; set; }
        //[MaxLength(4)]
        [Column(TypeName = "varchar(4)")] //### for mysql
        public string team_key { get; set; }
        //[MaxLength(4)]
        [Column(TypeName = "varchar(10)")] //### for mysql


        public string park_key { get; set; }
        //[MaxLength(4)]
        [Column(TypeName = "varchar(20)")] //### for mysql
              
        public string span_first { get; set; }

        //[MaxLength(4)]
        [Column(TypeName = "varchar(10)")]
        public string span_last { get; set; }
        //[MaxLength(4)]
        //year.key,league.key,team.key,park.key,span.first,span.last,games,openings,attendance
        //1871,NA,BS1,BOS01,1871-05-16,1871-10-07,16,16,32600
        [Column(TypeName = "varchar(4)")]
        public string games { get; set; }
        //[MaxLength(4)]

        
        [Column(TypeName = "varchar(4)")]
        public string openings { get; set; }
        [Column(TypeName = "varchar(10)")]
        public string attendance { get; set; }
    }
}
