using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace textLinesToObjects.DTO
{
    public class TextLineDTO
    {
       // [Required]
        // [MaxLength(10), MinLength(5)]
        [MaxLength(4)]
        public string yearID { get; set; }
        [MaxLength(4)]
        public string lgID { get; set; }
        [MaxLength(4)]
        public string teamID { get; set; }
        [MaxLength(4)]
        public string franchID { get; set; }
        [MaxLength(4)]
        public string divID { get; set; }
        [MaxLength(4)]
        public string Rank { get; set; }
        [MaxLength(4)]
        public string Ghome { get; set; }
        [MaxLength(4)]
        public string DivWin { get; set; }
        [MaxLength(4)]
        public string WCWin { get; set; }
        [MaxLength(4)]
        public string LgWin { get; set; }
        [MaxLength(4)]
        public string WSWin { get; set; }

        [MaxLength(50)]
        public string name { get; set; }
        [MaxLength(50)]
        public string park { get; set; }
        [MaxLength(4)]
        public string attendance { get; set; }
        [MaxLength(4)]
        public string BPF { get; set; }
        [MaxLength(4)]
        public string PPF { get; set; }
        [MaxLength(4)]
        public string teamIDBR { get; set; }
        [MaxLength(4)]
        public string teamIDlahman45 { get; set; }
        [MaxLength(4)]
        public string teamIDretro { get; set; }

    }
}
