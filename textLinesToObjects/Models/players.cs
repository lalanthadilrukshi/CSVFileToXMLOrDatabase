using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace textLinesToObjects.Models
{
    public class players
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //playerId,displayName,height,weight,dob,position,origin
        public int Id { get; set; } //### if this primary key is not added, there will be an error when adding records (to the dbcontext - dataset )
                                    // ## [MaxLength(4)] for sql server
        //playerId,displayName,height,weight,dob,position,origin
      
        [Column(TypeName = "varchar(20)")] //### for mysql
        public string playerId { get; set; }
       
        [Column(TypeName = "varchar(4)")] //### for mysql
        public string displayName { get; set; }
        //[MaxLength(4)]
        [Column(TypeName = "varchar(4)")] //### for mysql


        public string height { get; set; }
        //[MaxLength(4)]
        [Column(TypeName = "varchar(4)")] //### for mysql


        public string weight { get; set; }
        //[MaxLength(4)]
        //playerId,displayName,height,weight,dob,position,origin

         [Column(TypeName = "varchar(4)")]
        public string dob { get; set; }

        //[MaxLength(4)]
        [Column(TypeName = "varchar(4)")]
        public string position { get; set; }
        //[MaxLength(4)]

        [Column(TypeName = "varchar(4)")]
        public string origin { get; set; }
        //[MaxLength(4)]
                       
    }
}
