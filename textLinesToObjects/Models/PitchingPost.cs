using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace textLinesToObjects.Models
{
    public class PitchingPost
    {
        //playerID,yearID,round,teamID,lgID,W,L,G,GS,CG,SHO,SV,IPouts,H,ER,HR,BB,SO,BAOpp,ERA,IBB,WP,HBP,BK,BFP,GF,R,SH,SF,GIDP
        //becanbu01,1884,WS,NY4,AA,0,1,1,1,1,0,0,18,9,7,0,2,1,,10.5,,,,,,0,12,,,
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; } //### if this primary key is not added, there will be an error when adding records (to the dbcontext - dataset )
                                    // ## [MaxLength(4)] for sql server

      
        [Column(TypeName = "varchar(20)")] //### for mysql
        public string playerID { get; set; }
        
        [Column(TypeName = "varchar(4)")] //### for mysql
        public string yearID { get; set; }
        //[MaxLength(4)]
        [Column(TypeName = "varchar(10)")] //### for mysql
        public string round { get; set; }
        //[MaxLength(4)]
        [Column(TypeName = "varchar(20)")] //### for mysql
        public string teamID { get; set; }
        //[MaxLength(4)]
        //playerID,yearID,round,teamID,lgID,W,L,G,GS,CG,SHO,SV,IPouts,H,ER,HR,BB,SO,BAOpp,ERA,IBB,WP,HBP,BK,BFP,GF,R,SH,SF,GIDP
        [Column(TypeName = "varchar(10)")] //### for mysql
           
        public string lgID { get; set; }
        //[MaxLength(4)]

        [Column(TypeName = "varchar(10)")]
        public string W { get; set; }
        //[MaxLength(4)]
        [Column(TypeName = "varchar(10)")]
        public string L { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string G { get; set; }
        [Column(TypeName = "varchar(10)")]
        public string GS { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string CG { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string SHO { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string SV { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string IPouts { get; set; }
        //playerID,yearID,round,teamID,lgID,W,L,G,GS,CG,SHO,SV,IPouts,H,ER,HR,BB,SO,BAOpp,ERA,IBB,WP,HBP,BK,BFP,GF,R,SH,SF,GIDP
        [Column(TypeName = "varchar(10)")]
        public string H { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string ER { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string HR { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string BB { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string SO { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string BAOpp { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string ERA { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string IBB { get; set; }
        //playerID,yearID,round,teamID,lgID,W,L,G,GS,CG,SHO,SV,IPouts,H,ER,HR,BB,SO,BAOpp,ERA,IBB,WP,HBP,BK,BFP,GF,R,SH,SF,GIDP
        [Column(TypeName = "varchar(10)")]
        public string WP { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string HBP { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string BK { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string BFP { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string GF { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string R { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string SH { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string SF { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string GIDP { get; set; }


    }
}
