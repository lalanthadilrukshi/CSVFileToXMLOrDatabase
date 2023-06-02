using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace textLinesToObjects.Models
{
    //playerID,yearID,teamID,lgID,inseason,G,W,L,rank,plyrMgr
    //wrighha01,1871,BS1,NA,1,31,20,10,3,Y
    public class Managers
    {
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


        public string lgID { get; set; }
        //[MaxLength(4)]
        [Column(TypeName = "varchar(4)")] //### for mysql
        //playerID,yearID,teamID,lgID,inseason,G,W,L,rank,plyrMgr     
        public string inseason { get; set; }

        //[MaxLength(4)]
        [Column(TypeName = "varchar(4)")]
        public string G { get; set; }
        //[MaxLength(4)]

        [Column(TypeName = "varchar(4)")]
        public string W { get; set; }
        //[MaxLength(4)]
        [Column(TypeName = "varchar(4)")]
        public string L { get; set; }

        [Column(TypeName = "varchar(4)")]
        public string rank { get; set; }
        [Column(TypeName = "varchar(4)")]
        public string plyrMgr { get; set; }
    }
}
