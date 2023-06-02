using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace textLinesToObjects.Models
{
    public class stats
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //gameId,team,year,round,playerId,displayName,gameNumber,Disposals,Kicks,Marks,Handballs,Goals,Behinds,Hit Outs,Tackles,Rebounds,Inside 50s,Clearances,Clangers,Frees,Frees Against,Brownlow Votes,Contested Possessions,Uncontested Possessions,Contested Marks,Marks Inside 50,One Percenters,Bounces,Goal Assists,% Played,Subs
        //2021R104,Adelaide,2021,R1,2021661124,"Berry, Sam",1,8,6,1,2,0,1,0,7,0,2,3,2,2,2,0,4,5,0,0,0,0,1,80,-
        public int Id { get; set; } //### if this primary key is not added, there will be an error when adding records (to the dbcontext - dataset )
                                    // ## [MaxLength(4)] for sql server
    
        [Column(TypeName = "varchar(20)")] //### for mysql
        public string gameId { get; set; }
       
        [Column(TypeName = "varchar(20)")] //### for mysql
        public string team { get; set; }
        //[MaxLength(4)]
        [Column(TypeName = "varchar(4)")] //### for mysql

        public string year { get; set; }
        //[MaxLength(4)]
        [Column(TypeName = "varchar(10)")] //### for mysql

        public string round { get; set; }
        //[MaxLength(4)]
        [Column(TypeName = "varchar(20)")] //### for mysql
         public string playerId { get; set; }
        // gameNumber,Disposals,Kicks,Marks,Handballs,Goals,Behinds,Hit Outs, Tackles, Rebounds, Inside 50s,Clearances,Clangers,Frees,Frees Against, Brownlow Votes,Contested Possessions, Uncontested Possessions,Contested Marks, Marks Inside 50,One Percenters, Bounces, Goal Assists,% Played,Subs
        //2021R104,Adelaide,2021,R1,2021661124,"Berry, Sam",1,8,6,1,2,0,1,0,7,0,2,3,2,2,2,0,4,5,0,0,0,0,1,80,-
        //[MaxLength(4)]
        [Column(TypeName = "varchar(30)")]
        public string displayName { get; set; }
        //[MaxLength(4)]

        [Column(TypeName = "varchar(10)")]
        public string gameNumber { get; set; }
        //[MaxLength(4)]
        [Column(TypeName = "varchar(4)")]
        public string Disposals { get; set; }
        [Column(TypeName = "varchar(4)")]
        public string Kicks { get; set; }
        [Column(TypeName = "varchar(4)")]
        public string Marks { get; set; }
        [Column(TypeName = "varchar(4)")]
        public string Handballs { get; set; }
        [Column(TypeName = "varchar(4)")]
        public string Goals { get; set; }
        [Column(TypeName = "varchar(4)")]
        public string Behinds { get; set; }
        [Column(TypeName = "varchar(4)")]
        public string Hit_Outs { get; set; }
        [Column(TypeName = "varchar(4)")]
       // Tackles, Rebounds, Inside 50s,Clearances,Clangers,Frees,Frees Against, Brownlow Votes,Contested Possessions, Uncontested Possessions,Contested Marks, Marks Inside 50,One Percenters, Bounces, Goal Assists,% Played,Subs

        public string Tackles { get; set; }
        [Column(TypeName = "varchar(4)")]
        public string Rebounds { get; set; }
        [Column(TypeName = "varchar(4)")]
        public string Inside_50s { get; set; }
        [Column(TypeName = "varchar(4)")]
        public string Clearances { get; set; }
        [Column(TypeName = "varchar(4)")]
        public string Clangers { get; set; }
        [Column(TypeName = "varchar(4)")]
        public string Frees { get; set; }
        [Column(TypeName = "varchar(4)")]
        public string Frees_Against { get; set; }
        [Column(TypeName = "varchar(4)")]
        public string Brownlow_Votes { get; set; }
        [Column(TypeName = "varchar(4)")]
        public string Contested_Possessions { get; set; }
        [Column(TypeName = "varchar(4)")]
        public string Uncontested_Possessions { get; set; }
        [Column(TypeName = "varchar(4)")]
       // Contested Possessions, Uncontested Possessions,Contested Marks, Marks Inside 50,One Percenters, Bounces, Goal Assists,% Played,Subs

        public string Contested_Marks { get; set; }
        [Column(TypeName = "varchar(4)")]
        public string Marks_Inside_50 { get; set; }
        [Column(TypeName = "varchar(4)")]
        public string One_Percenters { get; set; }
        [Column(TypeName = "varchar(4)")]
        public string Bounces { get; set; }
        [Column(TypeName = "varchar(4)")]
        public string Goal_Assists { get; set; }
        [Column(TypeName = "varchar(4)")]
        public string Percentage_Played { get; set; }
        [Column(TypeName = "varchar(4)")]
        public string Subs { get; set; }

    }
}
