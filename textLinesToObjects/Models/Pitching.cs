using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace textLinesToObjects.Models
{
    public class Pitching
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //playerID,yearID,stint,teamID,lgID,W,L,G,GS,CG,SHO,SV,IPouts,H,ER,HR,BB,SO,BAOpp,ERA,IBB,WP,HBP,BK,BFP,GF,R,SH,SF,GIDP
        //bechtge01,1871,1,PH1,NA,1,2,3,3,2,0,0,78,43,23,0,11,1,,7.96,,7,,0,146,0,42
        public int Id { get; set; } //### if this primary key is not added, there will be an error when adding records (to the dbcontext - dataset )
                                    // ## [MaxLength(4)] for sql server

        [Column(TypeName = "varchar(20)")] //### for mysql
        public string playerID { get; set; }
      
        [Column(TypeName = "varchar(4)")] //### for mysql
        public string yearID { get; set; }
        //[MaxLength(4)]
        [Column(TypeName = "varchar(4)")] //### for mysql


        public string stint { get; set; }
        //[MaxLength(4)]
        [Column(TypeName = "varchar(10)")] //### for mysql

       // playerID,yearID,stint,teamID,lgID,W,L,G,GS,CG,SHO,SV,IPouts,H,ER,HR,BB,SO,BAOpp,ERA,IBB,WP,HBP,BK,BFP,GF,R,SH,SF,GIDP
        public string teamID { get; set; }
        //[MaxLength(4)]
        [Column(TypeName = "varchar(10)")] //### for mysql
               
        public string lgID { get; set; }

        //[MaxLength(4)]
        [Column(TypeName = "varchar(10)")]
        public string W { get; set; }
        //[MaxLength(4)]

        [Column(TypeName = "varchar(10)")]
        public string L { get; set; }
        //[MaxLength(4)]


        [Column(TypeName = "varchar(10)")]
        public string G { get; set; }
        [Column(TypeName = "varchar(10)")]
        public string GS { get; set; }
        // playerID,yearID,stint,teamID,lgID,W,L,G,GS,CG,SHO,SV,IPouts,H,ER,HR,BB,SO,BAOpp,ERA,IBB,WP,HBP,BK,BFP,GF,R,SH,SF,GIDP
        [Column(TypeName = "varchar(10)")]
        public string CG { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string SHO { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string SV { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string IPouts { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string H { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string ER { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string HR { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string BB { get; set; }
        // playerID,yearID,stint,teamID,lgID,W,L,G,GS,CG,SHO,SV,IPouts,H,ER,HR,BB,SO,BAOpp,ERA,IBB,WP,HBP,BK,BFP,GF,R,SH,SF,GIDP
        [Column(TypeName = "varchar(10)")]
        public string SO { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string BAOpp { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string ERA { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string IBB { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string WP { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string HBP { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string BK { get; set; }
        // playerID,yearID,stint,teamID,lgID,W,L,G,GS,CG,SHO,SV,IPouts,H,ER,HR,BB,SO,BAOpp,ERA,IBB,WP,HBP,BK,BFP,GF,R,SH,SF,GIDP
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
