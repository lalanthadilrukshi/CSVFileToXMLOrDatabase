using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace textLinesToObjects.Models
{
    public class AwardsShareManagers //AwardsSharePlayers and AwardsShareManagers same database model
    {
        //awardID,yearID,lgID,playerID,pointsWon,pointsMax,votesFirst
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //BBWAA Manager of the Year,1983,AL,altobjo01,7,28,7

        public int Id { get; set; } //### if this primary key is not added, there will be an error when adding records (to the dbcontext - dataset )
                                    // ## [MaxLength(4)] for sql server


        [Column(TypeName = "varchar(100)")] //### for mysql
        public string awardID { get; set; }
        [Column(TypeName = "varchar(4)")] //### for mysql
        public string yearID { get; set; }

        [Column(TypeName = "varchar(4)")]
        public string lgID { get; set; }
        [Required]
        [Column(TypeName = "varchar(20)")] //### for mysql
        public string playerID { get; set; }
              
        [Column(TypeName = "varchar(4)")]

        public string pointsWon { get; set; }
        
        [Column(TypeName = "varchar(4)")]
        public string pointsMax { get; set; }

        [Column(TypeName = "varchar(4)")]
        public string votesFirst { get; set; }




    }
}
