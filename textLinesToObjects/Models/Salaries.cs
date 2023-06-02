using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace textLinesToObjects.Models
{
    public class Salaries
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //yearID,teamID,lgID,playerID,salary
        //1985,ATL,NL,barkele01,870000
        public int Id { get; set; } //### if this primary key is not added, there will be an error when adding records (to the dbcontext - dataset )
                                    // ## [MaxLength(4)] for sql server

        [Column(TypeName = "varchar(20)")] //### for mysql
        public string yearID { get; set; }
       
        [Column(TypeName = "varchar(10)")] //### for mysql
        public string teamID { get; set; }
        //[MaxLength(4)]
        [Column(TypeName = "varchar(10)")] //### for mysql


        public string lgID { get; set; }
        //[MaxLength(4)]
        [Column(TypeName = "varchar(20)")] //### for mysql


        public string playerID { get; set; }
        //[MaxLength(4)]
        [Column(TypeName = "varchar(20)")] //### for mysql

        public string salary { get; set; }

        
    }
}
