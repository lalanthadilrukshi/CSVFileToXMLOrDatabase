using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace textLinesToObjects.Models
{
    public class nfl_stadiums
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //stadium_name,stadium_location,stadium_open,stadium_close,stadium_type,stadium_address,stadium_weather_station_code,stadium_weather_type,stadium_capacity,stadium_surface,STATION,NAME,LATITUDE,LONGITUDE,ELEVATION
       
        //Giants Stadium,"East Rutherford, NJ",1976,2009,outdoor,"1 MetLife Stadium Dr, East Rutherford, NJ 07073",7073,cold,,,USW00014734,"NEWARK LIBERTY INTERNATIONAL AIRPORT, NJ US",40.6825,-74.1694,2.1
       
        public int Id { get; set; } //### if this primary key is not added, there will be an error when adding records (to the dbcontext - dataset )
                                    // ## [MaxLength(4)] for sql server

  
        [Column(TypeName = "varchar(20)")] //### for mysql
        public string stadium_name { get; set; }
     
        [Column(TypeName = "varchar(100)")] //### for mysql
        public string stadium_location { get; set; }
        //[MaxLength(4)]
        [Column(TypeName = "varchar(4)")] //### for mysql


        public string stadium_open { get; set; }
        //[MaxLength(4)]
        [Column(TypeName = "varchar(4)")] //### for mysql


        public string stadium_close { get; set; }
        //[MaxLength(4)]
        [Column(TypeName = "varchar(20)")] //### for mysql

        //Giants Stadium,"East Rutherford, NJ",1976,2009,outdoor,"1 MetLife Stadium Dr, East Rutherford, NJ 07073",7073,cold,,,USW00014734,"NEWARK LIBERTY INTERNATIONAL AIRPORT, NJ US",40.6825,-74.1694,2.1

        public string stadium_type { get; set; }

        //[MaxLength(4)]
        [Column(TypeName = "varchar(100)")]
        public string stadium_address { get; set; }
        //[MaxLength(4)]

        [Column(TypeName = "varchar(4)")]
        public string stadium_weather_station_code { get; set; }
        //[MaxLength(4)]


        [Column(TypeName = "varchar(10)")]
        public string stadium_weather_type { get; set; }

        //stadium_name,stadium_location,stadium_open,stadium_close,stadium_type,stadium_address,stadium_weather_station_code,stadium_weather_type,stadium_capacity,stadium_surface,STATION,NAME,LATITUDE,LONGITUDE,ELEVATION
        //Giants Stadium,"East Rutherford, NJ",1976,2009,outdoor,"1 MetLife Stadium Dr, East Rutherford, NJ 07073",7073,cold,,,USW00014734,"NEWARK LIBERTY INTERNATIONAL AIRPORT, NJ US",40.6825,-74.1694,2.1


        //,cold,,,USW00014734,"NEWARK LIBERTY INTERNATIONAL AIRPORT, NJ US",40.6825,-74.1694,2.1

        [Column(TypeName = "varchar(10)")]
        public string stadium_capacity { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string stadium_surface { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string STATION { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string NAME { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string LATITUDE { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string LONGITUDE { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string ELEVATION { get; set; }

        
    }
}
