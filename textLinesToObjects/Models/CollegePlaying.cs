using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace textLinesToObjects.Models
{
    public class CollegePlaying
    {

        //playerID,schoolID,yearID
        //aardsda01,pennst,2001
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; } //### if this primary key is not added, there will be an error when adding records (to the dbcontext - dataset )
                                    // ## [MaxLength(4)] for sql server

     
        [Column(TypeName = "varchar(20)")] //### for mysql
        public string playerID { get; set; }
        [Column(TypeName = "varchar(20)")] //### for mysql
        public string schoolID { get; set; }
     
        [Column(TypeName = "varchar(4)")] //### for mysql
        public string yearID { get; set; }
   }
}
