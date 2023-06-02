using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace textLinesToObjects.Models
{
    public class TeamsHalf
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //yearID,lgID,teamID,Half,divID,DivWin,Rank,G,W,L
        //1981,NL,ATL,1,W,N,4,54,25,29
        public int Id { get; set; } //### if this primary key is not added, there will be an error when adding records (to the dbcontext - dataset )
                                    // ## [MaxLength(4)] for sql server

    
        [Column(TypeName = "varchar(4)")] //### for mysql
        public string yearID { get; set; }
     
        [Column(TypeName = "varchar(10)")] //### for mysql
        public string lgID { get; set; }
        //[MaxLength(4)]
        [Column(TypeName = "varchar(10)")] //### for mysql


        public string teamID { get; set; }
        //[MaxLength(4)]
        [Column(TypeName = "varchar(10)")] //### for mysql


        public string Half { get; set; }
        //[MaxLength(4)]
        [Column(TypeName = "varchar(10)")] //### for mysql

        //yearID,lgID,teamID,Half,divID,DivWin,Rank,G,W,L
        public string divID { get; set; }

        //[MaxLength(4)]
        [Column(TypeName = "varchar(10)")]
        public string DivWin { get; set; }
        //[MaxLength(4)]

        [Column(TypeName = "varchar(10)")]
        public string Rank { get; set; }
        //[MaxLength(4)]


        [Column(TypeName = "varchar(10)")]
        public string G { get; set; }
        //[MaxLength(4)]

        [Column(TypeName = "varchar(10)")]
        public string W { get; set; }


        [Column(TypeName = "varchar(10)")]
        public string L { get; set; }
    }
}
