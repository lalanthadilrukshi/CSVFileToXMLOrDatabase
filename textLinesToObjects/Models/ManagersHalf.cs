using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace textLinesToObjects.Models
{
    public class ManagersHalf
    {//playerID,yearID,teamID,lgID,inseason,half,G,W,L,rank
        //hanlone01,1892,BLN,NL,3,1,56,17,39,12
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
               
        public string inseason { get; set; }

        //[MaxLength(4)]
        [Column(TypeName = "varchar(4)")]
        public string half { get; set; }
        //[MaxLength(4)]

        [Column(TypeName = "varchar(4)")]
        public string G { get; set; }
        //[MaxLength(4)]
        //playerID,yearID,teamID,lgID,inseason,half,G,W,L,rank

        [Column(TypeName = "varchar(4)")]
        public string W { get; set; }
        [Column(TypeName = "varchar(4)")]
        public string L { get; set; }
        [Column(TypeName = "varchar(4)")]
        public string rank { get; set; }
    }
}
