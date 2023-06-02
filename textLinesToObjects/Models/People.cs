using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace textLinesToObjects.Models
{
    public class People
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //playerID,birthYear,birthMonth,birthDay,birthCountry,birthState,birthCity,deathYear,deathMonth,deathDay,deathCountry,deathState,deathCity,nameFirst,nameLast,nameGiven,weight,height,bats,throws,debut,finalGame,retroID,bbrefID
        //aardsda01,1981,12,27,USA,CO,Denver,,,,,,,David,Aardsma,David Allan,215,75,R,R,2004-04-06,2015-08-23,aardd001,aardsda01
        public int Id { get; set; } //### if this primary key is not added, there will be an error when adding records (to the dbcontext - dataset )
                                    // ## [MaxLength(4)] for sql server

      
        [Column(TypeName = "varchar(20)")] //### for mysql
        public string playerID { get; set; }
        
        [Column(TypeName = "varchar(4)")] //### for mysql
        public string birthYear { get; set; }
        //[MaxLength(4)]
        [Column(TypeName = "varchar(4)")] //### for mysql


        public string birthMonth { get; set; }
        //[MaxLength(4)]
        [Column(TypeName = "varchar(4)")] //### for mysql

        //playerID,birthYear,birthMonth,birthDay,birthCountry,birthState,birthCity,deathYear,deathMonth,deathDay,deathCountry,deathState,deathCity,nameFirst,nameLast,nameGiven,weight,height,bats,throws,debut,finalGame,retroID,bbrefID
        
        public string birthDay { get; set; }
        //[MaxLength(4)]
        [Column(TypeName = "varchar(30)")] //### for mysql
               
        public string birthCountry { get; set; }

        //[MaxLength(4)]
        [Column(TypeName = "varchar(30)")]
        public string birthState { get; set; }
        //[MaxLength(4)]

        [Column(TypeName = "varchar(30)")]
        public string birthCity { get; set; }
        //[MaxLength(4)]
        //playerID,birthYear,birthMonth,birthDay,birthCountry,birthState,birthCity,deathYear,deathMonth,deathDay,deathCountry,deathState,deathCity,nameFirst,nameLast,nameGiven,weight,height,bats,throws,debut,finalGame,retroID,bbrefID
        //aardsda01,1981,12,27,USA,CO,Denver,,,,,,,David,Aardsma,David Allan,215,75,R,R,2004-04-06,2015-08-23,aardd001,aardsda01

        [Column(TypeName = "varchar(4)")]
        public string deathYear { get; set; }

        [Column(TypeName = "varchar(4)")]
        public string deathMonth { get; set; }

        [Column(TypeName = "varchar(4)")]
        public string startingPos { get; set; }

        [Column(TypeName = "varchar(4)")]
        public string deathDay { get; set; }

        [Column(TypeName = "varchar(4)")]
        public string deathCountry { get; set; }

        [Column(TypeName = "varchar(4)")]
        public string deathState { get; set; }

        [Column(TypeName = "varchar(4)")]
        public string deathCity { get; set; }

        [Column(TypeName = "varchar(30)")]
        public string nameFirst { get; set; }

        [Column(TypeName = "varchar(30)")]
        public string nameLast { get; set; }

        //playerID,birthYear,birthMonth,birthDay,birthCountry,birthState,birthCity,deathYear,deathMonth,deathDay,deathCountry,deathState,deathCity,nameFirst,nameLast,nameGiven,weight,height,bats,throws,debut,finalGame,retroID,bbrefID
        //aardsda01,1981,12,27,USA,CO,Denver,,,,,,,David,Aardsma,David Allan,215,75,R,R,2004-04-06,2015-08-23,aardd001,aardsda01
        [Column(TypeName = "varchar(30)")]
        public string nameGiven { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string weight { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string height { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string bats { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string throws { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string debut { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string finalGame { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string retroID { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string bbrefID { get; set; }
               
    }
}
