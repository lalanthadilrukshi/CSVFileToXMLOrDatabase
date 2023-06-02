using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace textLinesToObjects.Models
{
    public class Schools
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
       // abilchrist,Abilene Christian University,Abilene,TX,USA
        //schoolID,name_full,city,state,country
        public int Id { get; set; } //### if this primary key is not added, there will be an error when adding records (to the dbcontext - dataset )
                                    // ## [MaxLength(4)] for sql server

      
        [Column(TypeName = "varchar(20)")] //### for mysql
        public string schoolID { get; set; }
     
        [Column(TypeName = "varchar(100)")] //### for mysql
        public string name_full { get; set; }
        //[MaxLength(4)]
        [Column(TypeName = "varchar(30)")] //### for mysql


        public string city { get; set; }
        //[MaxLength(4)]
        [Column(TypeName = "varchar(30)")] //### for mysql


        public string state { get; set; }
        //[MaxLength(4)]
        [Column(TypeName = "varchar(30)")] //### for mysql

        public string country { get; set; }

       
    }
}
