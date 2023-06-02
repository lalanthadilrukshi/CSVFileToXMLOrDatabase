using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace textLinesToObjects.Models
{
    public class nfl_teams
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        // team_name,team_name_short,team_id,team_id_pfr,team_conference,team_division,team_conference_pre2002,team_division_pre2002
        //Arizona Cardinals,Cardinals,ARI,CRD,NFC,NFC West,NFC,NFC West
        public int Id { get; set; } //### if this primary key is not added, there will be an error when adding records (to the dbcontext - dataset )
                                    // ## [MaxLength(4)] for sql server

    
        [Column(TypeName = "varchar(100)")] //### for mysql
        public string team_name { get; set; }
      
        [Column(TypeName = "varchar(20)")] //### for mysql
        public string team_name_short { get; set; }
        //[MaxLength(4)]
        [Column(TypeName = "varchar(10)")] //### for mysql


        public string team_id { get; set; }
        //[MaxLength(4)]
        [Column(TypeName = "varchar(10)")] //### for mysql


        public string team_id_pfr { get; set; }
        //[MaxLength(4)]
        [Column(TypeName = "varchar(10)")] //### for mysql

        // team_name,team_name_short,team_id,team_id_pfr,team_conference,team_division,team_conference_pre2002,team_division_pre2002
        public string team_conference { get; set; }

        //[MaxLength(4)]
        [Column(TypeName = "varchar(10)")]
        public string team_division { get; set; }
        //[MaxLength(4)]

        [Column(TypeName = "varchar(10)")]
        public string team_conference_pre2002 { get; set; }
        //[MaxLength(4)]


        [Column(TypeName = "varchar(10)")]
        public string team_division_pre2002 { get; set; }
    }
}
