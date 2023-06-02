using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace textLinesToObjects.Models
{
    public class FieldingPost
    {//playerID,yearID,teamID,lgID,round,POS,G,GS,InnOuts,PO,A,E,DP,TP,PB,SB,CS
        //beaumgi01,1903,PIT,NL,WS,CF,8,8,210,21,0,0,0,0,,,
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; } //### if this primary key is not added, there will be an error when adding records (to the dbcontext - dataset )
                                    // ## [MaxLength(4)] for sql server

     
        [Column(TypeName = "varchar(20)")] //### for mysql
        public string playerID { get; set; }
      
        [Column(TypeName = "varchar(4)")] //### for mysql
        public string yearID { get; set; }
        //[MaxLength(4)]
        [Column(TypeName = "varchar(4)")] //### for mysql
        public string teamID { get; set; }
        //[MaxLength(4)]
        [Column(TypeName = "varchar(4)")] //### for mysql
                //playerID,yearID,teamID,lgID,round,POS,G,GS,InnOuts,PO,A,E,DP,TP,PB,SB,CS
        public string lgID { get; set; }
        //[MaxLength(4)]
        [Column(TypeName = "varchar(4)")] //### for mysql
             
        public string round { get; set; }

        //[MaxLength(4)]
        [Column(TypeName = "varchar(4)")]
        public string POS { get; set; }
        //[MaxLength(4)]
                [Column(TypeName = "varchar(4)")]
        public string G { get; set; }
        //[MaxLength(4)]
        //playerID,yearID,teamID,lgID,round,POS,G,GS,InnOuts,PO,A,E,DP,TP,PB,SB,CS
        [Column(TypeName = "varchar(4)")]
        public string GS { get; set; }
        [Column(TypeName = "varchar(4)")]
        public string InnOuts { get; set; }

        [Column(TypeName = "varchar(4)")]
        public string PO { get; set; }
        [Column(TypeName = "varchar(4)")]
        public string A { get; set; }
        [Column(TypeName = "varchar(4)")]
        public string E { get; set; }
        [Column(TypeName = "varchar(4)")]
        public string DP { get; set; }
        [Column(TypeName = "varchar(4)")]
        public string TP { get; set; }
        [Column(TypeName = "varchar(4)")]
        public string PB { get; set; }
        [Column(TypeName = "varchar(4)")]
        public string SB { get; set; }
        [Column(TypeName = "varchar(4)")]
        public string CS { get; set; }
       
       

    }
}
