using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace textLinesToObjects.Models
{
    public class Appearances
    {
        //  yearID,teamID,lgID,playerID,G_all,GS,G_batting,G_defense,G_p,G_c,G_1b,G_2b,G_3b,G_ss,G_lf,G_cf,G_rf,G_of,G_dh,G_ph,G_pr
       // 1871,TRO,NA,abercda01,1,1,1,1,0,0,0,0,0,1,0,0,0,0,0,0,0
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; } //### if this primary key is not added, there will be an error when adding records (to the dbcontext - dataset )
                                    // ## [MaxLength(4)] for sql server

     
        [Column(TypeName = "varchar(4)")] //### for mysql
        public string yearID { get; set; }
        //[MaxLength(4)]
                    
        [Column(TypeName = "varchar(4)")]
        public string teamID { get; set; }

        //[MaxLength(4)]
        [Column(TypeName = "varchar(4)")]
        public string lgID { get; set; }
        //[MaxLength(4)]
       
        [Column(TypeName = "varchar(20)")] //### for mysql
        public string playerID { get; set; }

        [Column(TypeName = "varchar(4)")]
        public string G_all { get; set; }

      

        [Column(TypeName = "varchar(4)")]
        public string GS { get; set; }

        [Column(TypeName = "varchar(4)")]
        public string G_batting { get; set; }

        [Column(TypeName = "varchar(4)")]
        public string G_defense { get; set; }

        [Column(TypeName = "varchar(4)")]
        public string G_p { get; set; }

        [Column(TypeName = "varchar(4)")]
        public string G_c { get; set; }

        [Column(TypeName = "varchar(4)")]
        public string G_1b { get; set; }

        [Column(TypeName = "varchar(4)")]
        public string G_2b { get; set; }

        [Column(TypeName = "varchar(4)")]
        public string G_3b { get; set; }

        [Column(TypeName = "varchar(4)")]
        public string G_ss { get; set; }

        [Column(TypeName = "varchar(4)")]
        public string G_lf { get; set; }


        [Column(TypeName = "varchar(4)")]
        public string G_cf { get; set; }

        [Column(TypeName = "varchar(4)")]
        public string G_rf { get; set; }

        [Column(TypeName = "varchar(4)")]
        public string G_of { get; set; }

        [Column(TypeName = "varchar(4)")]
        public string G_dh { get; set; }

        [Column(TypeName = "varchar(4)")]
        public string G_ph { get; set; }

        [Column(TypeName = "varchar(4)")]
        public string G_pr { get; set; }


    }
}
