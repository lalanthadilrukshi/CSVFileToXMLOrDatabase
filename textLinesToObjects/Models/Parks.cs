using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace textLinesToObjects.Models
{
    public class Parks
    {
        //park.key,park.name,park.alias,city,state,country
        //ALB01,Riverside Park,,Albany,NY,US
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; } //### if this primary key is not added, there will be an error when adding records (to the dbcontext - dataset )
                                    // ## [MaxLength(4)] for sql server

       
        [Column(TypeName = "varchar(20)")] //### for mysql
        public string park_key { get; set; }
       
        [Column(TypeName = "varchar(100)")] //### for mysql
        public string park_name { get; set; }
        //[MaxLength(4)]
        [Column(TypeName = "varchar(20)")] //### for mysql


        public string park_alias { get; set; }
        //[MaxLength(4)]
        [Column(TypeName = "varchar(4)")] //### for mysql

        //park.key,park.name,park.alias,city,state,country
        public string city { get; set; }
        //[MaxLength(4)]
        [Column(TypeName = "varchar(20)")] //### for mysql
                
        public string state { get; set; }

        //[MaxLength(4)]
        [Column(TypeName = "varchar(20)")]
        public string country { get; set; }
        //[MaxLength(4)]

        
    }
}
