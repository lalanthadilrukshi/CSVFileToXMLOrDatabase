using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace textLinesToObjects.Models
{
    public class games
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        // gameId,year,round,date,venue,startTime,attendance,homeTeam,homeTeamScore,awayTeam,awayTeamScore,rainfall
        //2021R101,2021,R1,18-Mar-2021,M.C.G.,7:25 PM,49218,Richmond,105,Carlton,80,0.0
        public int Id { get; set; } //### if this primary key is not added, there will be an error when adding records (to the dbcontext - dataset )
                                    // ## [MaxLength(4)] for sql server

    
        [Column(TypeName = "varchar(20)")] //### for mysql
        public string gameId { get; set; }
       
        [Column(TypeName = "varchar(4)")] //### for mysql
        public string year { get; set; }
        //[MaxLength(4)]
        [Column(TypeName = "varchar(4)")] //### for mysql

        public string round { get; set; }
        //[MaxLength(4)]
        [Column(TypeName = "varchar(20)")] //### for mysql
         public string date { get; set; }
        //[MaxLength(4)]
        [Column(TypeName = "varchar(100)")] //### for mysql 
        // gameId,year,round,date,venue,startTime,attendance,homeTeam,homeTeamScore,awayTeam,awayTeamScore,rainfall
        public string venue { get; set; }
                //[MaxLength(4)]
        [Column(TypeName = "varchar(20)")]
        public string startTime { get; set; }
        //[MaxLength(4)]

        [Column(TypeName = "varchar(10)")]
        public string attendance { get; set; }
        //[MaxLength(4)]
        [Column(TypeName = "varchar(100)")]
        public string homeTeam { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string homeTeamScore { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string awayTeam { get; set; }
        [Column(TypeName = "varchar(10)")]
        public string awayTeamScore { get; set; }
        [Column(TypeName = "varchar(10)")]
        public string rainfall { get; set; }
    }
}
