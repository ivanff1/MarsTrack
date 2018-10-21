using System.IO.Ports;

namespace Mars_Track_Display_Simulation
{
    public class GetData
    {

        public static string GetTemperatureData(SerialPort commPort)
        {
           commPort.Open();// Opens the communication port on COM4(Fixed variable)
            
            //while (true)
         //   {
                  commPort.Write("TEMPD");//Writes to the port
                  string temperature = commPort.ReadLine();// Reads line from the port and converts it to a float
                   //commPort.Write("HUMID");
                  //string humidity = commPort.ReadLine();
                   return temperature;//, humidity.ToString()};.ToString()

            // }
        }
        public static string GetObjectRange(SerialPort commPort)
        {
            float range = 0;
            for (int i = 0; i < 6; i++)
            {
                commPort.Write("RANGEF");
                range += float.Parse(commPort.ReadLine());
            }
            return (range / 6).ToString();
            
        }
    }
}
