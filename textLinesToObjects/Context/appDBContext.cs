/*
using Microsoft.EntityFrameworkCore;
using textLinesToObjects.DTO;
using Microsoft.Extensions.Configuration;

*/
using textLinesToObjects.Models;

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace textLinesToObjects.Context
{
    public class appDBContext: DbContext
    {

        public appDBContext(DbContextOptions<appDBContext> options)
            : base(options)
        {
        }

        public DbSet<racingData> racingdata { get; set; }//# for testing
        public DbSet<AllstarFull> AllstarFull { get; set; }
        public DbSet<Appearances> Appearances { get; set; }
        public DbSet<AwardsManagers> AwardsManagers { get; set; }
        public DbSet<AwardsPlayers> AwardsPlayers { get; set; }
        public DbSet<AwardsShareManagers> AwardsShareManagers { get; set; }
        public DbSet<AwardsSharePlayers> AwardsSharePlayers { get; set; }
        public DbSet<Batting> Batting { get; set; }
        public DbSet<BattingPost> BattingPost { get; set; }
        public DbSet<CollegePlaying> CollegePlaying { get; set; }
        public DbSet<Fielding> Fielding { get; set; }
        public DbSet<FieldingOF> FieldingOF { get; set; }
        public DbSet<FieldingOFsplit> FieldingOFsplit { get; set; }
        public DbSet<FieldingPost> FieldingPost { get; set; }
        public DbSet<games> games { get; set; }
        public DbSet<HallOfFame> HallOfFame { get; set; }
        public DbSet<HomeGames> HomeGames { get; set; }
        public DbSet<Managers> Managers { get; set; }
        public DbSet<ManagersHalf> ManagersHalf { get; set; }
        public DbSet<nfl_stadiums> nfl_stadiums { get; set; }
        public DbSet<nfl_teams> nfl_teams { get; set; }
        public DbSet<Parks> Parks { get; set; }
        public DbSet<People> People { get; set; }
        public DbSet<Pitching> Pitching { get; set; }
        public DbSet<PitchingPost> PitchingPost { get; set; }
        public DbSet<players> players { get; set; }
        public DbSet<Salaries> Salaries { get; set; }
        public DbSet<Schools> Schools { get; set; }
        public DbSet<SeriesPost> SeriesPost { get; set; }
        public DbSet<spreadspoke_scores> spreadspoke_scores { get; set; }
        public DbSet<stats> stats { get; set; }
        public DbSet<Teams> Teams { get; set; }
        public DbSet<Teams2> Teams2 { get; set; }
        public DbSet<TeamsFranchises> TeamsFranchises { get; set; }
        public DbSet<TeamsHalf> TeamsHalf { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Seed cities Table
           


        }
    }

}
