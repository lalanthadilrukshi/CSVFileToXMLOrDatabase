using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace textLinesToObjects.Models
{
   
    public class racingData
    {// ## this model was created first for testing the application 
        // public string Id { get; set; } //### default primary key, other wise you would get compiling error The entity type 'racingData' requires a primary key to be defined.
        //this is the key
        // [Required]
        // [MaxLength(10), MinLength(5)]
        // [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        // public string Id { get; set; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

          public int Id { get; set; } //### if this primary key is not added, there will be an error when adding records (to the dbcontext - dataset )
       // ## [MaxLength(4)] for sql server

    
        [Column(TypeName = "varchar(4)")] //### for mysql
        public string yearID { get; set; }
        //[MaxLength(4)]
        [Column(TypeName = "varchar(4)")] //### for mysql
        public string lgID { get; set; }
        //[MaxLength(4)]
        [Column(TypeName = "varchar(4)")]
        public string teamID { get; set; }
        //[MaxLength(4)]
        [Column(TypeName = "varchar(4)")]
        public string franchID { get; set; }
        //[MaxLength(4)]
        [Column(TypeName = "varchar(4)")]
        public string divID { get; set; }
        // [MaxLength(4)]
        [Column(TypeName = "varchar(4)")]
        public string Rank { get; set; }
        // [MaxLength(4)]
        [Column(TypeName = "varchar(4)")]
        public string Ghome { get; set; }
        //[MaxLength(4)]
        [Column(TypeName = "varchar(4)")]
        public string DivWin { get; set; }
        // [MaxLength(4)]
        [Column(TypeName = "varchar(4)")]
        public string WCWin { get; set; }
        //[MaxLength(4)]
        [Column(TypeName = "varchar(4)")]
        public string LgWin { get; set; }
        // [MaxLength(4)]
        [Column(TypeName = "varchar(4)")]
        public string WSWin { get; set; }

        // [MaxLength(50)]
        [Column(TypeName = "varchar(50)")]
        public string name { get; set; }
        // [MaxLength(100)] // ## for 50 , the value gets truncated and exception thrown
        [Column(TypeName = "varchar(100)")]
        public string park { get; set; } 
           // [MaxLength(10)] // ## for 4 , the value gets truncated and exception thrown
        [Column(TypeName = "varchar(10)")]
        public string attendance { get; set; }
           // [MaxLength(4)]
        [Column(TypeName = "varchar(4)")]
        public string BPF { get; set; }
        // [MaxLength(4)]
        [Column(TypeName = "varchar(4)")]
        public string PPF { get; set; }
        // [MaxLength(4)]
        [Column(TypeName = "varchar(4)")]
        public string teamIDBR { get; set; }
        // [MaxLength(4)]
        [Column(TypeName = "varchar(4)")]
        public string teamIDlahman45 { get; set; }
        // [MaxLength(4)]
        [Column(TypeName = "varchar(4)")]
        public string teamIDretro { get; set; }

        }
    }






