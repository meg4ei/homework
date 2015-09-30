using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;

namespace Exam
{
    public class Helpers
    {
            public static List<Countries> GetCountry()
            {
                List<Countries> countries = new List<Countries>();
                using (StreamReader reader = new StreamReader(ConfigurationManager.AppSettings["FilePath"]))
                {
                    string line = reader.ReadLine();
                    do
                    {
                        string[] counry = line.Split('|');
                        countries.Add(new Countries()
                        {
                            Country = counry[0],
                            City = counry[1],
                            Population = long.Parse(counry[2]),
                        });
                        line = reader.ReadLine();
                    } while (line != null);
                }
                return countries;
            }
        }
    }
