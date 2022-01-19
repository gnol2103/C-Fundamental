using System;
using C__fundamental_3.Events;
using System.IO;
using System.Text;

namespace C__fundamental_3.Business
{
    public class LogClockToFile
    {
        public void Subscribe(Clock clock)
        {
            clock.SecondChange += new Clock.SecondChangeHandler(WriteToFile);
        }

        private void WriteToFile(object clock, TimeInfoEventArgs args)
        {
            string outputString = args.hour + ":" + args.minute + ":" + args.second;
            using (FileStream stream = File.Open("E://Log1.txt", FileMode.OpenOrCreate))
            {
                byte[] bytes = new UTF8Encoding(true).GetBytes(outputString);
                stream.Write(bytes, 0, bytes.Length);
            }
            using (StreamWriter writer=new StreamWriter("E://LogStreamWriter.txt",true)){
                writer.WriteLine(outputString);
            }
        }
    }
}