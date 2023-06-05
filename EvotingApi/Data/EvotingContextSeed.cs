using EvotingApi.Entities;
using System.Collections.Generic;
using System.Linq;

namespace EvotingApi.Data
{
    public class EvotingContextSeed
    {
        public static void SeedData(EvotingContext context)
        {
            if (!context.Voters.Any())
            {
                var voters = new List<Voter>
                {
                    new Voter ()
                    {
                        Name = "Nadia Hassan Kamal" ,
                        Date = null,
                        CandidateId= null,
                        Candidate = null,
                        Code = string.Empty,
                        IsVoting = false,
                        Token = string.Empty,
                        Adress = "Cairo" ,
                        Age= 21,
                        Email="nadiahassankamalhesein@gmail.com",
                        IsDead=false,
                        NationalId="30109290103823"
                        
                    },
                    new Voter ()
                    {
                        Name = "Aya Salah Abdalstar" ,
                        Adress = "Cairo" ,
                        Age= 15,
                        Email="ayasalah8555@gmail.com",
                        IsDead=false,
                        NationalId="30810164325911"
                        
                    },
                    new Voter ()
                    {
                        Name = "Rehab Refat Ahmed" ,
                        Adress = "Cairo" ,
                        Age= 43,
                        Email="rehabrefat03@gmail.com",
                        IsDead=false,
                        NationalId="28010060101346"
                       
                    },
                    new Voter ()
                    {
                        Name = "Ahmed Hassan Kamal" ,
                        Adress = "Cairo" ,
                        Age= 20,
                        Email="nadiahassankamalhesein@gmail.com",
                        IsDead=false,
                        NationalId="303090574215"
                        
                    },
                    new Voter ()
                    {
                        Name = "omar khaled kamal" ,
                        Adress = "Cairo" ,
                        Age= 65,
                        Email="omar003@gmail.com",
                        IsDead=true,
                        NationalId="26704082145123"
                        
                    },
                    new Voter ()
                    {
                        Name = "Mohamed Hassan Kamal" ,
                        Adress = "Cairo" ,
                        Age= 17,
                        Email="mohamed003@gmail.com",
                        IsDead=false,
                        NationalId="30607040105979"
                        
                    },
                    new Voter ()
                    {
                        Name = "Esraa Abdou Abdou" ,
                        Adress = "Cairo" ,
                        Age= 26,
                        Email="esraaabdou27@gmail.com",
                        IsDead=false,
                        NationalId="29704210903311"
                     


                    },

                    new Voter ()
                    {
                        Name = "Salma Mohamed Kamal" ,
                        Adress = "Cairo" ,
                        Age= 14,
                        Email="salma23@gmail.com",
                        IsDead=true,
                        NationalId="30905234547901"
                       


                    },
                    new Voter ()
                    {
                        Name = "Abdo Hassan Kamal" ,
                        Adress = "Cairo" ,
                        Age= 19,
                        Email="nadiahassankamalhesein@gmail.com",
                        IsDead=false,
                        NationalId="30309060100913"
                      


                    },
                    new Voter ()
                    {
                        Name = "Mohamed Salah Abdalstar" ,
                        Adress = "Cairo" ,
                        Age= 80,
                        Email="ayasalah8555@gmail.com",
                        IsDead=false,
                        NationalId="24311264457918"
                       
                    },
                    new Voter ()
                    {
                        Name = "Doha Ahmed sayed" ,
                        Adress = "Cairo" ,
                        Age= 40,
                        Email="adoha3354@gmail.com",
                        IsDead=false,
                        NationalId="28312156789542"
                        
                    },
                    new Voter ()
                    {
                        Name = "Alaa Ahmed Abdelal" ,
                        Adress = "Cairo" ,
                        Age= 68,
                        Email="alaaloaa188@gmail.com",
                        IsDead=false,
                        NationalId="25509271234565"
                       
                    },
                    new Voter ()
                    {
                        Name = "Esraa Shaban Abdelqwi" ,
                        Adress = "Cairo" ,
                        Age= 96,
                        Email="esraashaban266@gmail.com",
                        IsDead=true,
                        NationalId="22708124567807"
                       
                    },
                    new Voter ()
                    {
                        Name = "Yuosef Shaban Abdelqwi" ,
                        Adress = "Cairo" ,
                        Age= 16,
                        Email="esraashaban266@gmail.com",
                        IsDead=false,
                        NationalId="30708291234567"
                       
                    },
                    new Voter ()
                    {
                        Name = "Aya Abdel nasser mohamed" ,
                        Adress = "Cairo" ,
                        Age= 50,
                        Email="farwelanasser@gmail.com",
                        IsDead=false,
                        NationalId="27311071357924"
                        
                    },
                    new Voter ()
                    {
                        Name = "Rowida Mohamed Mustafa" ,
                        Adress = "Cairo" ,
                        Age= 33,
                        Email="mohamedrwida33@gmail.com",
                        IsDead=false,
                        NationalId="29007081235781"
                       
                    },
                   new Voter ()
                    {
                        Name = "Farha Shehata Ibrahim" ,
                        Adress = "Cairo" ,
                        Age= 83,
                        Email="farhashehata78@gmail.com",
                        IsDead=false,
                        NationalId="24012219876541"
                        
                    },
                   new Voter ()
                    {
                        Name = "Mariam Shehata Ibrahim" ,
                        Adress = "Cairo" ,
                        Age= 92,
                        Email="meroshehata55@gmail.com",
                        IsDead=false,
                        NationalId="23105178765432"
                      
                    },
                  new Voter ()
                    {
                        Name = "Mervat Tohamy Ibrahim" ,
                        Adress = "Cairo" ,
                        Age= 62,
                        Email="mrftthamy62@gmail.com",
                        IsDead=false,
                        NationalId="26101094567843"
                        
                    },
                  new Voter ()
                    {
                        Name = "Saif Mohamed sayed" ,
                        Adress = "Cairo" ,
                        Age= 71,
                        Email="mohassan691210@gmail.com",
                        IsDead=false,
                        NationalId="25209172345678"
                       
                    },
                  new Voter ()
                    {
                        Name = "Habeba Ahmed Hassan" ,
                        Adress = "Cairo" ,
                        Age= 35,
                        Email="yanaqw4@gmail.com",
                        IsDead=true,
                        NationalId="28810172345678"
                        
                    },
                  new Voter ()
                    {
                        Name = "Fatma Abdelrehem Ahmed" ,
                        Adress = "Cairo" ,
                        Age= 48,
                        Email="fatmaabdelrehemahmed@gmail.com",
                        IsDead=false,
                        NationalId="27504200100522"
                       
                    }
                };
                context.Voters.AddRange(voters);
                context.SaveChanges();
            }
            if (!context.Candidates.Any())
            {
                var Candidates = new List<Candidate>
                {
                    new Candidate ()
                    {
                        Name="Sayed Ali",
                        
                        NumberofVoters = 0,
                        Information = "He was born on 2 May 1944 in Alexandria, and obtained a secondary industriPoliticianal diploma. When he reached the age of eighteen, he was appointed to one of the factories in Cairo. Then, in 1962, he moved to the National Company for Spinning and Weaving in Karmouz in Alexandria Governorate to work in an atmosphere characterized by revolutionary and labor activity, so he began his political activity. Immediately after his military service with the Youth Organization in 1966, he entered the elections of the Socialist Union in 1968 and succeeded in them, and again in 1971 and succeeded in them as well until he reached the executive office of the Socialist Union. ",
                        Party = "The Liberal",
                        Region = "Maadi",
                        PhotoPath = "https://drive.google.com/file/d/1nZLZeHz4RvYiIYcdprrx_Hv84ULbMvmz/view?usp=share_link"
                    },new Candidate ()
                    {
                        Name="Mostafa Ahmed",
                        
                        Information = "He was born on 25 November 1941 in Giza. He graduated from the Air Force College in 1961, after which he worked as a pilot in the Egyptian Air Force and participated in the wars of attrition and October 1973 against Israel. He held the position of Prime Minister of Egypt from January 29, 2011 to March 3, 2011, and before his presidency of the Council of Ministers he was Minister of Civil Aviation since 2002.",
                        NumberofVoters = 0,
                        Party = "Wafd",
                        Region = "Maadi",
                        PhotoPath = "https://drive.google.com/file/d/1SS6gKgeFOw9PoY2B-QRajLEY2HeTNBIk/view?usp=share_link"
                    }
                    ,new Candidate ()
                    {
                        Name="Mohamed Ahmed",
                        
                        Information = "He was born on July 22, 1945. He obtained a Bachelor’s degree in Military Sciences in 1964 and a Bachelor’s degree in Commerce in 1982. He studied political intelligence and administrative skills. He began his life as an officer in the paratroopers and participated in the October 1973 war, in which he received the Medal of Military Duty of the first class.",
                        NumberofVoters = 0,
                        Party = "National Democratic",
                        Region = "Maadi",
                        PhotoPath = "https://drive.google.com/file/d/1URJ2DTUU7SzgMCKrSj4oii4A37P5ZqE5/view?usp=share_link"
                    }
                };
                context.Candidates.AddRange(Candidates);
                if(!context.Intervals.Any())
                    context.Intervals.Add(new Interval()
                    {
                        
                        StartDate = System.DateTime.UtcNow.AddHours(3),
                        EndDate = System.DateTime.UtcNow.AddDays(7)
                    });
                context.SaveChanges();
            }
        }

    }
}
