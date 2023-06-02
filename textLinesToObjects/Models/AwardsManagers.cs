using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace textLinesToObjects.Models
{
    public class AwardsManagers
    {
        //playerID,awardID,yearID,lgID,tie,notes
        //larusto01,BBWAA Manager of the Year,1983,AL,,
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; } //### if this primary key is not added, there will be an error when adding records (to the dbcontext - dataset )
                                    // ## [MaxLength(4)] for sql server

        [Column(TypeName = "varchar(20)")] //### for mysql

        public string playerID { get; set; }
               
        [Column(TypeName = "varchar(100)")] //### for mysql

        public string awardID { get; set; }
        //[MaxLength(4)]
        [Column(TypeName = "varchar(4)")]
        public string yearID { get; set; }
        //[MaxLength(4)]
        [Column(TypeName = "varchar(4)")] //### for mysql


            
        public string lgID { get; set; }
        //[MaxLength(4)]

        [Column(TypeName = "varchar(4)")]
        public string tie { get; set; }
        //[MaxLength(4)]


        [Column(TypeName = "varchar(4)")]
        public string notes { get; set; }
    }
}
