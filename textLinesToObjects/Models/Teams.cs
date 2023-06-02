using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace textLinesToObjects.Models
{
    public class Teams
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        // yearID,lgID,teamID,franchID,divID,Rank,Ghome,DivWin,WCWin,LgWin,WSWin,name,park,attendance,BPF,PPF,teamIDBR,teamIDlahman45,teamIDretro
        //1871,NA,BS1,BNA,,3,,,,N,,Boston Red Stockings,South End Grounds I,,103,98,BOS,BS1,BS1
        public int Id { get; set; } //### if this primary key is not added, there will be an error when adding records (to the dbcontext - dataset )
                                    // ## [MaxLength(4)] for sql server

    
        [Column(TypeName = "varchar(4)")] //### for mysql
        public string yearID { get; set; }
        //[MaxLength(4)]
        [Column(TypeName = "varchar(10)")] //### for mysql
        public string lgID { get; set; }
        //[MaxLength(4)]
        [Column(TypeName = "varchar(10)")]
        public string teamID { get; set; }
        //[MaxLength(4)]
        [Column(TypeName = "varchar(10)")]
        public string franchID { get; set; }
        //[MaxLength(4)]
        [Column(TypeName = "varchar(10)")]
        public string divID { get; set; }
        // [MaxLength(4)]
        [Column(TypeName = "varchar(10)")]
        public string Rank { get; set; }
        // [MaxLength(4)]
        [Column(TypeName = "varchar(10)")]
        public string Ghome { get; set; }
        //[MaxLength(4)]
        [Column(TypeName = "varchar(10)")]
        public string DivWin { get; set; }
        // [MaxLength(4)]
        [Column(TypeName = "varchar(10)")]
        public string WCWin { get; set; }
        //[MaxLength(4)]
        [Column(TypeName = "varchar(10)")]
        public string LgWin { get; set; }
        // [MaxLength(4)]
        [Column(TypeName = "varchar(10)")]
        public string WSWin { get; set; }

        // [MaxLength(50)]
        [Column(TypeName = "varchar(100)")]
        public string name { get; set; }
        // [MaxLength(100)] // ## for 50 , the value gets truncated and exception thrown
        [Column(TypeName = "varchar(100)")]
        public string park { get; set; }
        // [MaxLength(10)] // ## for 4 , the value gets truncated and exception thrown
        [Column(TypeName = "varchar(10)")]
        public string attendance { get; set; }
        // [MaxLength(4)]
        [Column(TypeName = "varchar(10)")]
        public string BPF { get; set; }
        // [MaxLength(4)]
        [Column(TypeName = "varchar(10)")]
        public string PPF { get; set; }
        // [MaxLength(4)]
        [Column(TypeName = "varchar(10)")]
        public string teamIDBR { get; set; }
        // [MaxLength(4)]
        [Column(TypeName = "varchar(10)")]
        public string teamIDlahman45 { get; set; }
        // [MaxLength(4)]
        [Column(TypeName = "varchar(10)")]
        public string teamIDretro { get; set; }
    }
}
