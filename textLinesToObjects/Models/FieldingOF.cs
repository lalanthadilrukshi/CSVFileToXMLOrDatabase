using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace textLinesToObjects.Models
{
    public class FieldingOF
    {
        //playerID,yearID,stint,Glf,Gcf,Grf
        //allisar01,1871,1,0,29,0
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


        public string stint { get; set; }
        //[MaxLength(4)]
        [Column(TypeName = "varchar(4)")] //### for mysql


        public string Glf { get; set; }
        //[MaxLength(4)]
        [Column(TypeName = "varchar(20)")] //### for mysql

        public string Gcf { get; set; }

        //[MaxLength(4)]
        [Column(TypeName = "varchar(4)")]
        public string Grf { get; set; }
        //[MaxLength(4)]
               
    }
}
