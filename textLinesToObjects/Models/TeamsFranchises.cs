using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace textLinesToObjects.Models
{
    public class TeamsFranchises
    {
        //ALT,Altoona Mountain City,N,
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //franchID,franchName,active,NAassoc
        public int Id { get; set; } //### if this primary key is not added, there will be an error when adding records (to the dbcontext - dataset )
                                    // ## [MaxLength(4)] for sql server

        [Column(TypeName = "varchar(20)")] //### for mysql
        public string franchID { get; set; }
        
        [Column(TypeName = "varchar(100)")] //### for mysql
        public string franchName { get; set; }
        //[MaxLength(4)]
        [Column(TypeName = "varchar(10)")] //### for mysql


        public string active { get; set; }
        //[MaxLength(4)]
        [Column(TypeName = "varchar(10)")] //### for mysql


        public string NAassoc { get; set; }
        
    }
}
