using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace textLinesToObjects.Models
{
    public class SeriesPost
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //yearID,round,teamIDwinner,lgIDwinner,teamIDloser,lgIDloser,wins,losses,ties
        //1884,WS,PRO,NL,NY4,AA,3,0,0
        public int Id { get; set; } //### if this primary key is not added, there will be an error when adding records (to the dbcontext - dataset )
                                    // ## [MaxLength(4)] for sql server

    
        [Column(TypeName = "varchar(20)")] //### for mysql
        public string yearID { get; set; }
      
        [Column(TypeName = "varchar(10)")] //### for mysql
        public string round { get; set; }
        //[MaxLength(4)]
        [Column(TypeName = "varchar(10)")] //### for mysql


        public string teamIDwinner { get; set; }
        //[MaxLength(4)]
        [Column(TypeName = "varchar(10)")] //### for mysql


        public string lgIDwinner { get; set; }
        //[MaxLength(4)]
        [Column(TypeName = "varchar(20)")] //### for mysql
        //yearID,round,teamIDwinner,lgIDwinner,teamIDloser,lgIDloser,wins,losses,ties
        public string teamIDloser { get; set; }

        //[MaxLength(4)]
        [Column(TypeName = "varchar(20)")]
        public string lgIDloser { get; set; }
        //[MaxLength(4)]

        [Column(TypeName = "varchar(10)")]
        public string wins { get; set; }
        //[MaxLength(4)]


        [Column(TypeName = "varchar(10)")]
        public string losses { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string ties { get; set; }
    }
}
