using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using textLinesToObjects.Context;

using textLinesToObjects.DTO;
using textLinesToObjects.Models;
using System.IO;
using Microsoft.EntityFrameworkCore;
namespace textLinesToObjects
{
    [Route("api/[controller]")]
    [ApiController]
    public class textLinesConverter : ControllerBase
    {
        private readonly appDBContext _context;
        public textLinesConverter(appDBContext context)
        {
            _context = context;
        }
         


        [HttpPost("ConvertCSV_To_XML")]
        // fortesting use Teams_testCSVReducedTolittleLines from E:\dil\dilracing_AtTharuProcessing\Projects\textLines_CSVFile_ToObjects_MySqlDatabase. upload only one file

        public async Task<ActionResult<IEnumerable<TextLineDTO>>> ConvertCSV_To_XML(List<IFormFile> FormFile)


        {
                try
                {

                    //## this procedure takes about 3 minutes to process about 4000lines with 19  columns 2022-05-26
                    List<TextLineDTO> records = new List<TextLineDTO>();
                     String message = "failure";

           
                foreach (var file in FormFile)// ##should take only one file. 
                {
                    List<string> lines = new List<string>();

                    //## this procedure takes about 3 minutes to process about 4000lines with 19  columns 2022-05-26

                    //###successsful -file in local machine _ when running from local machine successful
                    //### var FileUrl = @"E:/dil/dilracing_AtTharuProcessing/Projects/textLinesToObjects/baseballdatabank2022.2/upstream/Teams.csv"; //### successful when run on local pc but not on network

                    //###successful when running from local machine. it successfully accesses the file in the network TPLNAS
                    //###var FileUrl = @"//TPLNAS/Cache Data/Dilrukshi_TextToDbProject/Teams.csv";//### successfully works from local machine. but when run from other terminal is a failure there fore try to send whole file by post

                    using (var reader = new StreamReader(file.OpenReadStream()))
                    {
                        while (reader.Peek() >= 0)
                            lines.Add(reader.ReadLine());
                    }



                    //loop through each file line
                    int startlineNumber = 1; //## very first line is column names
                    for (int count = startlineNumber; count < lines.Count; count++)
                    // foreach (string line in lines)
                    {
                        string line = lines.ElementAt(count);
                        // List<string> cells = splitByQuotationAndNonQuotedBYComma(line);
                        string[] tokens = splitByQuotationAndNonQuotedBYComma(line); //cells.ToArray();
                                                                                     //string[] tokens = line.Split(',');
                        var obj = new TextLineDTO();
                        obj.yearID = tokens[0];
                        obj.lgID = tokens[1];
                        obj.teamID = tokens[2];
                        obj.franchID = tokens[3];
                        obj.divID = tokens[4];
                        obj.Rank = tokens[5];
                        obj.Ghome = tokens[6];
                        obj.DivWin = tokens[7];
                        obj.WCWin = tokens[8];
                        obj.LgWin = tokens[9];
                        obj.WSWin = tokens[10];
                        obj.name = tokens[11];
                        obj.park = tokens[12];
                        obj.attendance = tokens[13];
                        obj.BPF = tokens[14];
                        obj.PPF = tokens[15];
                        obj.teamIDBR = tokens[16];
                        obj.teamIDlahman45 = tokens[17];
                        obj.teamIDretro = tokens[18];



                        records.Add(obj);
                        /*
                        if (records.Count >980)
                            {
                            return records;
                        }
                        */
                    }

                    return records;
                }
                return null;
            }
            catch (Exception e)
            {

                return null;

            }
        }










        [HttpPost("savePostedTextFileToDatabase")]
        public async Task<string> savePostedTextFileToDatabase(List<IFormFile> FormFile)
        {
            String message = "failure";

            try
            {

                foreach (var file in FormFile)
                {
                    List<string> lines = new List<string>();

                    //## this procedure takes about 3 minutes to process about 4000lines with 19  columns 2022-05-26

                    //###successsful -file in local machine _ when running from local machine successful
                    //### var FileUrl = @"E:/dil/dilracing_AtTharuProcessing/Projects/textLinesToObjects/baseballdatabank2022.2/upstream/Teams.csv"; //### successful when run on local pc but not on network

                    //###successful when running from local machine. it successfully accesses the file in the network TPLNAS
                    //###var FileUrl = @"//TPLNAS/Cache Data/Dilrukshi_TextToDbProject/Teams.csv";//### successfully works from local machine. but when run from other terminal is a failure there fore try to send whole file by post

                    using (var reader = new StreamReader(file.OpenReadStream()))
                    {
                        while (reader.Peek() >= 0)
                            lines.Add(reader.ReadLine());
                    }



                    //loop through each file line
                    int startlineNumber = 1; //## very first line is column names
                    for (int count = startlineNumber; count < lines.Count; count++)
                    // foreach (string line in lines)
                    {
                        string line = lines[count];
                        string[] tokens = line.Split(',');
                        var obj = new racingData();
                        obj.yearID = tokens[0];
                        obj.lgID = tokens[1];
                        obj.teamID = tokens[2];
                        obj.franchID = tokens[3];
                        obj.divID = tokens[4];
                        obj.Rank = tokens[5];
                        obj.Ghome = tokens[6];
                        obj.DivWin = tokens[7];
                        obj.WCWin = tokens[8];
                        obj.LgWin = tokens[9];
                        obj.WSWin = tokens[10];
                        obj.name = tokens[11];
                        obj.park = tokens[12];
                        obj.attendance = tokens[13];
                        obj.BPF = tokens[14];
                        obj.PPF = tokens[15];
                        obj.teamIDBR = tokens[16];
                        obj.teamIDlahman45 = tokens[17];
                        obj.teamIDretro = tokens[18];

                        // _context.racingdata.Add(obj);
                        AddRecordToTable(Path.GetFileNameWithoutExtension(file.Name), obj);
                    }
                }
                await _context.SaveChangesAsync();
                return "successful";


                //return CreatedAtAction("GetService", new { id = service.Id }, service);  //### do not return objects with complex data types . there will be an error in jason conversion
            }
            catch (Exception e)
            {
                message = e.ToString();
                return message;

            }

        }


        [HttpGet("saveTextFileToDatabase")]
        public async Task<string> saveTextFileToDatabaseKeepForReference()//### successfully works from local machine. but when run from other terminal is a failure there fore try to send whole file by post
        {
            String message = "failure";

            try
            {


                //## this procedure takes about 3 minutes to process about 4000lines with 19  columns 2022-05-26

                //file in disk
                //var FileUrl = @"D:\CacheFile\ttestFile.txt";

                // \\TPLNAS\Cache Data\Dilrukshi_TextToDbProject

                //### var FileUrl = @"E:/dil/dilracing_AtTharuProcessing/Projects/textLinesToObjects/baseballdatabank2022.2/upstream/Teams.csv"; //### successful when run on local pc but not on network
                var FileUrl = @"//TPLNAS/Cache Data/Dilrukshi_TextToDbProject/Teams.csv";//### successfully works from local machine. but when run from other terminal is a failure there fore try to send whole file by post


                // var FileUrl = @"E:/dil\dilracing_AtTharuProcessing\Projects\textLinesToObjects\baseballdatabank - 2022.2\upstream\Teams.csv";

                //file lines
                string[] lines = System.IO.File.ReadAllLines(FileUrl);

                //loop through each file line
                int startlineNumber = 1; //## very first line is column names
                for (int count = startlineNumber; count < lines.Length; count++)
                // foreach (string line in lines)
                {
                    string line = lines[count];
                    string[] tokens = line.Split(',');
                    var obj = new racingData();
                    obj.yearID = tokens[0];
                    obj.lgID = tokens[1];
                    obj.teamID = tokens[2];
                    obj.franchID = tokens[3];
                    obj.divID = tokens[4];
                    obj.Rank = tokens[5];
                    obj.Ghome = tokens[6];
                    obj.DivWin = tokens[7];
                    obj.WCWin = tokens[8];
                    obj.LgWin = tokens[9];
                    obj.WSWin = tokens[10];
                    obj.name = tokens[11];
                    obj.park = tokens[12];
                    obj.attendance = tokens[13];
                    obj.BPF = tokens[14];
                    obj.PPF = tokens[15];
                    obj.teamIDBR = tokens[16];
                    obj.teamIDlahman45 = tokens[17];
                    obj.teamIDretro = tokens[18];

                    _context.racingdata.Add(obj);

                }
                await _context.SaveChangesAsync();
                return "successful";


                //return CreatedAtAction("GetService", new { id = service.Id }, service);  //### do not return objects with complex data types . there will be an error in jason conversion
            }
            catch (Exception e)
            {
                message = e.ToString();
                return message;

            }

        }





        [HttpGet]
        public async Task<ActionResult<IEnumerable<TextLineDTO>>> GetRecords()


        {
            try
            {

                //## this procedure takes about 3 minutes to process about 4000lines with 19  columns 2022-05-26
                List<TextLineDTO> records = new List<TextLineDTO>();
                //file in disk
                //var FileUrl = @"D:\testFile.txt";
                //var FileUrl = @"E:/dil/dilracing_AtTharuProcessing/Projects/textLinesToObjects/baseballdatabank2022.2/upstream/Teams.csv";
                var FileUrl = @"E:/dil/dilracing_AtTharuProcessing/Projects/textLines_CSVFile_ToObjects_MySqlDatabase/Teams_testCSVReducedTolittleLines.csv";
            //var FileUrl = @"E:/dil/dilracing_AtTharuProcessing/Projects/textLines_CSVFile_ToObjects_MySqlDatabase/Teams_testCSVReducedTolittleLines.csv";

            // var FileUrl = @"E:\dil\dilracing_AtTharuProcessing\Projects\textLinesToObjects\baseballdatabank - 2022.2\upstream\Teams.csv";

            //file lines
            string[] lines = System.IO.File.ReadAllLines(FileUrl);
            
            //loop through each file line
            //for (int count =1; count <20; count ++)
            foreach (string line in lines)

            {
               // List<string> cells = splitByQuotationAndNonQuotedBYComma(line);
               string[] tokens = splitByQuotationAndNonQuotedBYComma(line); //cells.ToArray();
                //string[] tokens = line.Split(',');
                var obj = new TextLineDTO();
                obj.yearID =  tokens[0];
                obj.lgID = tokens[1];
                obj.teamID = tokens[2];
                obj.franchID = tokens[3];
                obj.divID = tokens[4];
                obj.Rank = tokens[5];
                obj.Ghome = tokens[6];
                obj.DivWin = tokens[7];
                obj.WCWin = tokens[8];
                obj.LgWin = tokens[9];
                obj.WSWin = tokens[10];
                obj.name = tokens[11];
                obj.park = tokens[12];
                obj.attendance = tokens[13];
                obj.BPF = tokens[14];
                obj.PPF = tokens[15];
                obj.teamIDBR = tokens[16];
                obj.teamIDlahman45 = tokens[17];
                obj.teamIDretro = tokens[18];



                records.Add(obj);
                /*
                if (records.Count >980)
                    {
                    return records;
                }
                */
            }

            return records;
            }
            catch (Exception e)
            {
             
                return null;

            }
        }

       // private  DbSet<any> AddRecordToTable(Object obj)
        private void AddRecordToTable(string filename,Object obj)
        {
 DbSet<object> dbset;
            if (filename.Contains("AllstarFull"))
                    {
                 _context.AllstarFull.Add((AllstarFull)obj);
                return;
                    };
            if (filename.Contains("Appearances"))
            {
                _context.Appearances.Add((Appearances)obj);
                return;
            };
            if (filename.Contains("AwardsManagers"))
            {
                _context.AwardsManagers.Add((AwardsManagers)obj);
                return;
            };
            if (filename.Contains("AwardsPlayers"))
            {
                _context.AwardsPlayers.Add((AwardsPlayers)obj);
                return;
            };
            if (filename.Contains("AwardsShareManagers"))
            {
                _context.AwardsShareManagers.Add((AwardsShareManagers)obj);
                return;
            };
            if (filename.Contains("AwardsSharePlayers"))
            {
                _context.AwardsSharePlayers.Add((AwardsSharePlayers)obj);
                return;
            };

            if (filename.Contains("Batting"))
            {
                _context.Batting.Add((Batting)obj);
                return;
            };

            if (filename.Contains("BattingPost"))
            {
                _context.BattingPost.Add((BattingPost)obj);
                return;
            };

            if (filename.Contains("CollegePlaying"))
            {
                _context.CollegePlaying.Add((CollegePlaying)obj);
                return;
            };

            if (filename.Contains("Fielding"))
            {
                _context.Fielding.Add((Fielding)obj);
                return;
            };

            if (filename.Contains("FieldingOF"))
            {
                _context.FieldingOF.Add((FieldingOF)obj);
                return;
            };
            if (filename.Contains("FieldingOFsplit"))
            {
                _context.FieldingOFsplit.Add((FieldingOFsplit)obj);
                return;
            };
            if (filename.Contains("FieldingPost"))
            {
                _context.FieldingPost.Add((FieldingPost)obj);
                return;
            };
            if (filename.Contains("games"))
            {
                _context.games.Add((games)obj);
                return;
            };

            
            if (filename.Contains("HallOfFame"))
            {
                _context.HallOfFame.Add((HallOfFame)obj);
                return;
            };

            if (filename.Contains("HomeGames"))
            {
                _context.HomeGames.Add((HomeGames)obj);
                return;
            };

            if (filename.Contains("Managers"))
            {
                _context.Managers.Add((Managers)obj);
                return;
            };
            if (filename.Contains("nfl_stadiums"))
            {
                _context.nfl_stadiums.Add((nfl_stadiums)obj);
                return;
            };
            if (filename.Contains("nfl_teams"))
            {
                _context.nfl_teams.Add((nfl_teams)obj);
                return;
            };
            if (filename.Contains("Parks"))
            {
                _context.Parks.Add((Parks)obj);
                return;
            };
            if (filename.Contains("People"))
            {
                _context.People.Add((People)obj);
                return;
            };
            if (filename.Contains("Pitching"))
            {
                _context.Pitching.Add((Pitching)obj);
                return;
            };
            if (filename.Contains("PitchingPost"))
            {
                _context.PitchingPost.Add((PitchingPost)obj);
                return;
            };
            if (filename.Contains("players"))
            {
                _context.players.Add((players)obj);
                return;
            };
            if (filename.Contains("Salaries"))
            {
                _context.Salaries.Add((Salaries)obj);
                return;
            };
            if (filename.Contains("Schools"))
            {
                _context.Schools.Add((Schools)obj);
                return;
            };
            if (filename.Contains("SeriesPost"))
            {
                _context.SeriesPost.Add((SeriesPost)obj);
                return;
            };
            if (filename.Contains("spreadspoke_scores"))
            {
                _context.spreadspoke_scores.Add((spreadspoke_scores)obj);
                return;
            };
            if (filename.Contains("stats"))
            {
                _context.stats.Add((stats)obj);
                return;
            };
            if (filename.Contains("Teams"))
            {
                _context.Teams.Add((Teams)obj);
                return;
            };
            if (filename.Contains("Teams2"))
            {
                _context.Teams2.Add((Teams2)obj);
                return;
            };
            if (filename.Contains("TeamsFranchises"))
            {
                _context.TeamsFranchises.Add((TeamsFranchises)obj);
                return;
            };
            if (filename.Contains("TeamsHalf"))
            {
                _context.TeamsHalf.Add((TeamsHalf)obj);
                return;
            };
        

    }

    // private static List<string> splitByQuotationAndNonQuotedBYComma(string lineWithoutFirstComma)
    private static string[] splitByQuotationAndNonQuotedBYComma(string line)
        {
            //string line = "," + lineWithoutFirstComma; //### if line starts with quotation the line.Split('"') , the first in resulting array will be nullOrEmpty, but in string with only comma seperators (without quotations), the comma does not start at first location there fore in such case also to make first item invalid insert a comma and this item will be removed at end of function
           // string line = lineWithoutFirstComma;
           

            //loop through each file line
            //for (int count =1; count <20; count ++)
            string[] result= null;

            // int nextQuotationPos = -1;
            // int start = 0;
            string[] withinquotes;
               // nextQuotationPos = line.IndexOf('"', start);
                //string[] withinquotes = line.Split('"');
             withinquotes = (line + ",").Split('"');//## comma seperated sections must start with a comma. if there is a comma seperated section at beginning this is essential. `5,6,"test",6`
           // if (withinquotes.Equals(null)) // ### if there is no quotation mark in the string, the split result will be null
                if (withinquotes.Length ==1 ) // ### if there is no quotation mark in the string, the split result will be same string

                {
                    result = line.Split(','); 
            }
            else
            {
                List<string> columdata = new List<string>();

                for (int count = 0; count < withinquotes.Length; count++)
                {
                    string s = withinquotes[count];
                    //if (!String.IsNullOrEmpty(s))
                    // if (!String.Equals(s, ","))

                    if (count % 2 == 1) // take only odd position which represents the string enclosed by quotations
                    {

                        columdata.Add(s);
                    }
                    else // even number
                    {

                        //## examples of lines from csv.
                        //##a string within quotations will considered as one cell. and other cells without quotations seperated by commas
                        //## 1871,NA,BS1,BNA,,3,
                        //## 1871," USA, NA",BS1,BNA,,3,
                        //## "1871-1"," USA, NA",BS1,BNA,,3,
                        if (!String.IsNullOrEmpty(s))// ###very first will be null if quotation mark starts from zero postion or very first column of comma seperated line . ex 
                        {
                            string[] tokens = s.Split(',');// very first will be null 
                            for (int pos = 1; pos < tokens.Length; pos++)
                            {
                                columdata.Add(tokens[pos]);
                            }
                        }

                    }
                    // columdata.RemoveAt(0);
                   
                }
                result = columdata.ToArray();
            }
            return result;
        }
    }
}