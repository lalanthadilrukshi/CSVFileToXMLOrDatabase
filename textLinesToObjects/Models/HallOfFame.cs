using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace textLinesToObjects.Models
{
    public class HallOfFame
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


        public string gameNum { get; set; }
        //[MaxLength(4)]
        [Column(TypeName = "varchar(4)")] //### for mysql


        public string gameID { get; set; }
        //[MaxLength(4)]
        [Column(TypeName = "varchar(20)")] //### for mysql
               
        public string teamID { get; set; }

        //[MaxLength(4)]
        [Column(TypeName = "varchar(4)")]
        public string lgID { get; set; }
        //[MaxLength(4)]

        [Column(TypeName = "varchar(4)")]
        public string GP { get; set; }
        //[MaxLength(4)]


        [Column(TypeName = "varchar(4)")]
        public string startingPos { get; set; }
    }
}
