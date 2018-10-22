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
        static List<Tuple<string, string, string[]>> fullDataList = new List<Tuple<string, string, string[]>>();
        static List<Tuple<string, string, List<float>>> pureDataList = new List<Tuple<string, string, List<float>>>();
        static string filePath = @"D:\Projects\Challenges\MarsTrack\MarsTrack\Data Gathering\Gathered Data";
        
        static void Main(string[] args)
        {
            Thread startA = new Thread(new ThreadStart(StartDataColllection));
            startA.Start();
            
        }
        static void StartDataColllection()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(filePath);
            foreach (var file in directoryInfo.GetFiles())
            {
                if (file.ToString().Contains("Temp"))
                {
                    Console.Write("TEMPERATURE: ");
                    string fileDate = Regex.Match(file.ToString(), @"(\([^;]*)\)").ToString();
                    fullDataList.Add(new Tuple<string, string, string[]>("TEMP", fileDate, File.ReadAllLines(filePath + @"\" + file.ToString())));
                    Console.WriteLine("READY");
                }
                else if (file.ToString().Contains("SoilMoist"))
                {
                    Console.Write("SOIL MOISTURE: ");
                    string fileDate = Regex.Match(file.ToString(), @"(\([^;]*)\)").ToString();
                    fullDataList.Add(new Tuple<string, string, string[]>("SOILMOIST", fileDate, File.ReadAllLines(filePath + @"\" + file.ToString())));
                    Console.WriteLine("READY");
                }
                else if (file.ToString().Contains("Humid"))
                {
                    Console.Write("HUMIDITY: ");
                    string fileDate = Regex.Match(file.ToString(), @"(\([^;]*)\)").ToString();
                    fullDataList.Add(new Tuple<string, string, string[]>("HUM", fileDate, File.ReadAllLines(filePath + @"\" + file.ToString())));
                    Console.WriteLine("READY");
                }
                else
                {
                    Console.WriteLine("Invalid Data is in the file");
                }
                for (int i = 0; i < fullDataList.Count; i++)
                {
                    string dataType = fullDataList[i].Item1;
                    string collectionDate = fullDataList[i].Item2;
                    List<float> sensorData = new List<float>();

                    for (int f = 0; f < fullDataList[i].Item3.Count(); f++)
                    {
                        if (String.IsNullOrEmpty(fullDataList[i].Item3[f]))
                        {
                        }
                        else
                        {                            
                            fullDataList[i].Item3[f] = Regex.Replace(fullDataList[i].Item3[f], "<([^;]*)>", "");
                         //   Console.WriteLine(fullDataList[i].Item3[f]);
                            sensorData.Add(float.Parse(fullDataList[i].Item3[f], System.Globalization.NumberStyles.Any ,System.Globalization.CultureInfo.InvariantCulture));                           
                        }
                    }
                    for (int j = 0; j < fullDataList.Count; j++)
                    {
                        if (dataType.Equals("TEMP"))
                        {
                            
                            pureDataList.Add(new Tuple<string, string, List<float>>(dataType, collectionDate, sensorData.ToList()));                           
                        }
                        else if (dataType.Equals("HUM"))
                        {
                            pureDataList.Add(new Tuple<string, string, List<float>>(dataType, collectionDate, sensorData.ToList()));
                        }
                        else if (dataType.Equals("SOILMOIST"))
                        {
                            pureDataList.Add(new Tuple<string, string, List<float>>(dataType, collectionDate, sensorData.ToList()));
                        }
                        else
                        {
                            pureDataList.Add(new Tuple<string, string, List<float>>("UNKNOWN", "UNKNOWN", sensorData.ToList()));
                        }

                        dataType = String.Empty;
                        collectionDate = String.Empty;
                        sensorData.Clear();
                    }

                }
                for (int i = 0; i < pureDataList.Count; i++)
                {
                    float averageData = 0;

                    if (pureDataList[i].Item1.Equals("TEMP"))
                    {
                        foreach (float value in pureDataList[i].Item3)
                        {                           
                            averageData += value;
                        }                   
                        averageData = averageData / pureDataList[i].Item3.Count();
                        
                        File.WriteAllText(@"D:\Projects\Challenges\MarsTrack\MarsTrack\Data Gathering\Processed Data\" + pureDataList[i].Item1 + pureDataList[i].Item2 + "-Pocessed on-" + DateTime.Now.ToLongDateString() + ".txt", "Average air temperature is: " + averageData.ToString() + "°C");
                    }
                    else if (pureDataList[i].Item1.Equals("HUM"))
                    {
                        for (int m = 0; m < pureDataList[i].Item3.Count; m++)
                        {                            
                            averageData += pureDataList[i].Item3[m];
                        }
                                                    
                        averageData = averageData / pureDataList[i].Item3.Count();
                        File.WriteAllText(@"D:\Projects\Challenges\MarsTrack\MarsTrack\Data Gathering\Processed Data\" + pureDataList[i].Item1 + pureDataList[i].Item2 + "-Pocessed on-" + DateTime.Now.ToLongDateString() + ".txt", "Average air humidity is: " + averageData.ToString() + "%");
                    }
                    else if ((pureDataList[i].Item1.Equals("SOILMOIST")))
                    {
                        foreach (var value in pureDataList[i].Item3)
                        {
                            averageData += value;
                        }
                        averageData = averageData / pureDataList[i].Item3.Count();
                        
                        File.WriteAllText(@"D:\Projects\Challenges\MarsTrack\MarsTrack\Data Gathering\Processed Data\" + pureDataList[i].Item1 + pureDataList[i].Item2 + "-Pocessed on-" + DateTime.Now.ToLongDateString() + ".txt", "Average soil moisture is: " + averageData.ToString() + "%");
                    }
                    else
                    {
                    }
                }
            }
        }

        }
    }

