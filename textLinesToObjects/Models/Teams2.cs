using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace textLinesToObjects.Models
{
    public class Teams2
    {
        //yearID,lgID,teamID,franchID,divID,Rank,G,Ghome,W,L,DivWin,WCWin,LgWin,WSWin,R,AB,H,2B,3B,HR,BB,SO,SB,CS,HBP,SF,RA,ER,ERA,CG,SHO,SV,IPouts,HA,HRA,BBA,SOA,E,DP,FP,name,park,attendance,BPF,PPF,teamIDBR,teamIDlahman45,teamIDretro
        //1871,NA,BS1,BNA,,3,31,,20,10,,,N,,401,1372,426,70,37,3,60,19,73,16,,,303,109,3.55,22,1,3,828,367,2,42,23,243,24,0.834,Boston Red Stockings,South End Grounds I,,103,98, BOS, BS1, BS1
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        // yearID,lgID,teamID,franchID,divID,Rank,Ghome,DivWin,WCWin,LgWin,WSWin,name,park,attendance,BPF,PPF,teamIDBR,teamIDlahman45,teamIDretro
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

        //divID,Rank,G,Ghome,W,L,DivWin,WCWin,LgWin,WSWin,R,AB,H,2B,3B,HR,BB,SO,SB,CS,HBP,SF,RA,ER,ERA,CG,SHO,SV,IPouts,HA,HRA,BBA,SOA,E,DP,FP,name,park,attendance,BPF,PPF,teamIDBR,teamIDlahman45,teamIDretro

        [Column(TypeName = "varchar(10)")]
        public string Rank { get; set; }
        // [MaxLength(4)]
        [Column(TypeName = "varchar(10)")]
        public string Ghome { get; set; }
        //[MaxLength(4)]
        [Column(TypeName = "varchar(10)")]

        public string W { get; set; }
        //[MaxLength(4)]
        [Column(TypeName = "varchar(10)")]

        public string L { get; set; }
        //[MaxLength(4)]
        [Column(TypeName = "varchar(10)")]

        public string DivWin { get; set; }
        // [MaxLength(4)]
        [Column(TypeName = "varchar(10)")]
        public string WCWin { get; set; }
        //[MaxLength(4)]
        [Column(TypeName = "varchar(10)")]
        public string LgWin { get; set; }

       // LgWin,WSWin,R,AB,H,2B,3B,HR,BB,SO,SB,CS,HBP,SF,RA,ER,ERA,CG,SHO,SV,IPouts,HA,HRA,BBA,SOA,E,DP,FP,name,park,attendance,BPF,PPF,teamIDBR,teamIDlahman45,teamIDretro

        // [MaxLength(4)]
        [Column(TypeName = "varchar(10)")]
        public string WSWin { get; set; }

        // [MaxLength(50)]
        [Column(TypeName = "varchar(10)")]
        public string R { get; set; }
        [Column(TypeName = "varchar(10)")]

        public string AB { get; set; }
        [Column(TypeName = "varchar(10)")]

        public string H { get; set; }
        [Column(TypeName = "varchar(10)")]

        public string B2 { get; set; }
        [Column(TypeName = "varchar(10)")]

        public string B3 { get; set; }
        [Column(TypeName = "varchar(10)")]
        //3B,HR,BB,SO,SB,CS,HBP,SF,RA,ER,ERA,CG,SHO,SV,IPouts,HA,HRA,BBA,SOA,E,DP,FP,name,park,attendance,BPF,PPF,teamIDBR,teamIDlahman45,teamIDretro
        
        public string HR { get; set; }
        [Column(TypeName = "varchar(10)")]

        public string BB { get; set; }
        [Column(TypeName = "varchar(10)")]

        public string SO { get; set; }
        [Column(TypeName = "varchar(10)")]

        public string SB { get; set; }
        [Column(TypeName = "varchar(10)")]

        public string CS { get; set; }
        [Column(TypeName = "varchar(10)")]

        public string HBP { get; set; }
        [Column(TypeName = "varchar(10)")]
        //HBP,SF,RA,ER,ERA,CG,SHO,SV,IPouts,HA,HRA,BBA,SOA,E,DP,FP,name,park,attendance,BPF,PPF,teamIDBR,teamIDlahman45,teamIDretro

        public string SF { get; set; }
        [Column(TypeName = "varchar(10)")]

        public string RA { get; set; }
        [Column(TypeName = "varchar(10)")]

        public string ER { get; set; }
        [Column(TypeName = "varchar(10)")]

        public string ERA { get; set; }
        [Column(TypeName = "varchar(10)")]

        public string CG { get; set; }
        [Column(TypeName = "varchar(10)")]

        public string SHO { get; set; }
        [Column(TypeName = "varchar(10)")]

        public string SV { get; set; }
        [Column(TypeName = "varchar(10)")]
        //SV,IPouts,HA,HRA,BBA,SOA,E,DP,FP,name,park,attendance,BPF,PPF,teamIDBR,teamIDlahman45,teamIDretro

        public string IPouts { get; set; }
        [Column(TypeName = "varchar(10)")]

        public string HA { get; set; }
        [Column(TypeName = "varchar(10)")]

        public string HRA { get; set; }
        [Column(TypeName = "varchar(10)")]

        public string BBA { get; set; }
        [Column(TypeName = "varchar(10)")]

        public string SOA { get; set; }
        [Column(TypeName = "varchar(10)")]

        public string E { get; set; }
        [Column(TypeName = "varchar(10)")]
        //E,DP,FP,name,park,attendance,BPF,PPF,teamIDBR,teamIDlahman45,teamIDretro

        public string DP { get; set; }
        [Column(TypeName = "varchar(10)")]

        public string FP { get; set; }
        [Column(TypeName = "varchar(100)")]

        public string name { get; set; }
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
