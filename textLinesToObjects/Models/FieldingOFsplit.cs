using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace textLinesToObjects.Models
{
    public class FieldingOFsplit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //playerID,yearID,stint,teamID,lgID,POS,G,GS,InnOuts,PO,A,E,DP,PB,WP,SB,CS,ZR
        //aaronha01,1954,1,ML1,NL,LF,105,102,2773,205,4,6,0,,,,,
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
        [Column(TypeName = "varchar(4)")] //### for mysql

       // playerID,yearID,stint,teamID,lgID,POS,G,GS,InnOuts,PO,A,E,DP,PB,WP,SB,CS,ZR
        public string teamID { get; set; }
        //[MaxLength(4)]
        [Column(TypeName = "varchar(4)")] //### for mysql

       
        public string lgID { get; set; }

        //[MaxLength(4)]
        [Column(TypeName = "varchar(4)")]
        public string POS { get; set; }
        //[MaxLength(4)]

        [Column(TypeName = "varchar(4)")]
        public string G { get; set; }
        //[MaxLength(4)]


        [Column(TypeName = "varchar(4)")]
        public string GS { get; set; }
       // playerID,yearID,stint,teamID,lgID,POS,G,GS,InnOuts,PO,A,E,DP,PB,WP,SB,CS,ZR
        [Column(TypeName = "varchar(4)")]
        public string InnOuts { get; set; }
        [Column(TypeName = "varchar(4)")]
        public string PO { get; set; }
        [Column(TypeName = "varchar(4)")]
        public string A { get; set; }
        [Column(TypeName = "varchar(4)")]
        public string E { get; set; }
        public string DP { get; set; }
        [Column(TypeName = "varchar(4)")]
        public string PB { get; set; }
        public string WP { get; set; }
        [Column(TypeName = "varchar(4)")]
        public string SB { get; set; }
        public string CS { get; set; }
        [Column(TypeName = "varchar(4)")]
        // playerID,yearID,stint,teamID,lgID,POS,G,GS,InnOuts,PO,A,E,DP,PB,WP,SB,CS,ZR
        public string ZR { get; set; }
     
    }
}
