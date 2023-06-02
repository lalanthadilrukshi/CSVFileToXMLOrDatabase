using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace textLinesToObjects.Models
{
    public class BattingPost
    {
        //1884,WS,carrocl01,PRO,NL,3,10,2,1,0,0,0,1,0,,1,1,0,,,,
        //yearID,round,playerID,teamID,lgID,G,AB,R,H,2B,3B,HR,RBI,SB,CS,BB,SO,IBB,HBP,SH,SF,GIDP
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; } //### if this primary key is not added, there will be an error when adding records (to the dbcontext - dataset )
                                    // ## [MaxLength(4)] for sql server

        
        
        [Column(TypeName = "varchar(4)")] //### for mysql
        public string yearID { get; set; }

        [Column(TypeName = "varchar(4)")] //### for mysql
        public string round { get; set; }

        [Column(TypeName = "varchar(20)")] //### for mysql
        public string playerID { get; set; }
        //[MaxLength(4)]
        [Column(TypeName = "varchar(4)")] //### for mysql

        //yearID,round,playerID,teamID,lgID,G,AB,R,H,2B,3B,HR,RBI,SB,CS,BB,SO,IBB,HBP,SH,SF,GIDP
        public string teamID { get; set; }
        
        [Column(TypeName = "varchar(4)")]
        public string lgID { get; set; }
        //[MaxLength(4)]

        [Column(TypeName = "varchar(4)")]
        public string G { get; set; }
        [Column(TypeName = "varchar(4)")]
        public string AB { get; set; }
        [Column(TypeName = "varchar(4)")]
        public string R { get; set; }
        [Column(TypeName = "varchar(4)")]
        public string H { get; set; }
        [Column(TypeName = "varchar(4)")]
        public string B2 { get; set; }
        [Column(TypeName = "varchar(4)")]
        public string B3 { get; set; }
        [Column(TypeName = "varchar(4)")]
        public string HR { get; set; }
        [Column(TypeName = "varchar(4)")]
        public string RBI { get; set; }
        [Column(TypeName = "varchar(4)")]
        //yearID,round,playerID,teamID,lgID,G,AB,R,H,2B,3B,HR,RBI,SB,CS,BB,SO,IBB,HBP,SH,SF,GIDP
        public string SB { get; set; }
        [Column(TypeName = "varchar(4)")]
        public string CS { get; set; }

        [Column(TypeName = "varchar(4)")]
        public string BB { get; set; }
        [Column(TypeName = "varchar(4)")]
        public string SO { get; set; }
        [Column(TypeName = "varchar(4)")]
        public string IBB { get; set; }
        [Column(TypeName = "varchar(4)")]
        public string HBP { get; set; }
        [Column(TypeName = "varchar(4)")]
        public string SH { get; set; }
        [Column(TypeName = "varchar(4)")]
        public string SF { get; set; }
        [Column(TypeName = "varchar(4)")]
        public string GIDP { get; set; }
    }
}
