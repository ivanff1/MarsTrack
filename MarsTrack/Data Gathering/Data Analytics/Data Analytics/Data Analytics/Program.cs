using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Text.RegularExpressions;
using System.IO;
using System.Threading;

namespace Data_Analytics
{
    class Program
    {
        static List<Tuple<string, string, string[]>> fileNamesList = new List<Tuple<string, string, string[]>>();
        static List<Tuple<string, string, string[]>> clearList = new List<Tuple<string, string, string[]>>();
        static string filePath = @"E:\Git Repos\MarsTrack\MarsTrack\Gathered Data";
        
        static void Main(string[] args)
        {
            Thread startA = new Thread(new ThreadStart(StartDataColllection));
            startA.Start();
            
        }
        static void StartDataColllection()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(filePath);
            foreach (var fileName in directoryInfo.GetFiles())
            {
                if (fileName.ToString().Contains("Temp"))
                {
                    Console.Write("TEMPERATURE: ");
                    string fileDate = Regex.Match(fileName.ToString(), @"(\([^;]*)\)").ToString();
                    fileNamesList.Add(new Tuple<string, string, string[]>("TEMP", fileDate, File.ReadAllLines(filePath + @"\" + fileName.ToString())));
                    Console.WriteLine("READY");
                }
                else if (fileName.ToString().Contains("SoilMoist"))
                {
                    Console.Write("SOIL MOISTURE: ");
                    string fileDate = Regex.Match(fileName.ToString(), @"(\([^;]*)\)").ToString();
                    fileNamesList.Add(new Tuple<string, string, string[]>("SOILMOIST", fileDate, File.ReadAllLines(filePath + @"\" + fileName.ToString())));
                    Console.WriteLine("READY");
                }
                else if (fileName.ToString().Contains("Humid"))
                {
                    Console.Write("HUMIDITY: ");
                    string fileDate = Regex.Match(fileName.ToString(), @"(\([^;]*)\)").ToString();
                    fileNamesList.Add(new Tuple<string, string, string[]>("HUM", fileDate, File.ReadAllLines(filePath + @"\" + fileName.ToString())));
                    Console.WriteLine("READY");
                }
                else
                {
                    Console.WriteLine("Invalid Data is in the file");
                }
                for (int i = 0; i < fileNamesList.Count; i++)
                {
                    for (int j = 0; j < fileNamesList[i].Item3.Count(); j++)
                    {
                        if (String.IsNullOrEmpty(fileNamesList[i].Item3[j]))
                        {
                            Console.WriteLine("Empty");
                        }
                        else if (!String.IsNullOrEmpty(fileNamesList[i].Item3[j]))
                        {
                            if (fileNamesList[i].Item1.Equals("TEMP"))
                            {
                                for (int f = 0; f < fileNamesList[i].Item3.Length; f++)
                                {
                                    fileNamesList[i].Item3[f] = Regex.Replace(fileNamesList[i].Item3[j], "<([^;]*)>", "");
                                }

                                clearList.Add(new Tuple<string, string, string[]>(fileNamesList[i].Item1, fileNamesList[i].Item2, fileNamesList[i].Item3));
                            }
                            else if (fileNamesList[i].Item1.Equals("HUM"))
                            {
                                for (int f = 0; f < fileNamesList[i].Item3.Length; f++)
                                {
                                    fileNamesList[i].Item3[f] = Regex.Replace(fileNamesList[i].Item3[j], "<([^;]*)>", "");
                                }
                                fileNamesList[i].Item3[j] = Regex.Replace(fileNamesList[i].Item3[j], "<([^;]*)>", "");
                                clearList.Add(new Tuple<string, string, string[]>(fileNamesList[i].Item1, fileNamesList[i].Item2, fileNamesList[i].Item3));
                            }
                            else if (fileNamesList[i].Item1.Equals("SOILMOIST"))
                            {
                                for (int f = 0; f < fileNamesList[i].Item3.Length; f++)
                                {
                                    fileNamesList[i].Item3[f] = Regex.Replace(fileNamesList[i].Item3[j], "<([^;]*)>", "");
                                }
                                fileNamesList[i].Item3[j] = Regex.Replace(fileNamesList[i].Item3[j], "<([^;]*)>", "");
                                clearList.Add(new Tuple<string, string, string[]>(fileNamesList[i].Item1, fileNamesList[i].Item2, fileNamesList[i].Item3));
                            }
                            else
                            {
                                Console.WriteLine("OH SHIT, SOMETHING WENT HORIBBLY WRONG");
                            }
                        }
                    }
                }
                for (int i = 0; i < clearList.Count; i++)
                {
                    float averageData = 0;
                    if (clearList[i].Item1.Equals("TEMP"))
                    {
                        foreach (string line in clearList[i].Item3)
                        {
                            // Console.WriteLine(line);
                            averageData += float.Parse(line, CultureInfo.InvariantCulture.NumberFormat);
                        }
                        averageData /= clearList[i].Item3.Count();
                        File.WriteAllText(@"C:\Users\ivanf\Desktop\Sensors Data Tests\" + clearList[i].Item1 + clearList[i].Item2 + "-Pocessed on-" + DateTime.Now.ToLongDateString() + ".txt", "Average air temperature is: " + averageData.ToString());
                    }
                    else if (clearList[i].Item1.Equals("HUM"))
                    {
                        foreach (string line in clearList[i].Item3)
                        {
                            // Console.WriteLine(line);
                            averageData += float.Parse(line, CultureInfo.InvariantCulture.NumberFormat);
                        }
                        averageData /= clearList[i].Item3.Count();
                        File.WriteAllText(@"C:\Users\ivanf\Desktop\Sensors Data Tests\" + clearList[i].Item1 + clearList[i].Item2 + "-Pocessed on-" + DateTime.Now.ToLongDateString() + ".txt", "Average air humidity is: " + averageData.ToString());
                    }
                    else if ((clearList[i].Item1.Equals("SOILMOIST")))
                    {
                        foreach (string line in clearList[i].Item3)
                        {
                            // Console.WriteLine(line);
                            averageData += float.Parse(line, CultureInfo.InvariantCulture.NumberFormat);
                        }
                        averageData /= clearList[i].Item3.Count();
                        
                        File.WriteAllText(@"C:\Users\ivanf\Desktop\Sensors Data Tests\" + clearList[i].Item1 + clearList[i].Item2 + "-Pocessed on-" + DateTime.Now.ToLongDateString() + ".txt", "Average soil moisture is: " + averageData.ToString());
                    }
                    else
                    {

                    }
                }
            }
        }

        }
    }

