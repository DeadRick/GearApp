using System;
using System.IO;
using System.Text;

namespace Changing
{
    internal class Program
    {

        static string Changing(string line, string from, string to)
        {
            line = line.Replace(from, to);
            line = line.Replace("GetAngleP1", "GetAngleP1" + to);
            line = line.Replace("GetAngleP2", "GetAngleP2" + to);
            line = line.Replace("GetAnglePk", "GetAnglePk" + to);
            line = line.Replace("AngleCoef", "AngleCoef" + to);
            line = line.Replace("GetSpeedP1", "GetSpeedP1" + to);
            line = line.Replace("GetSpeedP2", "GetSpeedP2" + to);
            line = line.Replace("GetSpeedPk", "GetSpeedPk" + to);
            line = line.Replace("SpeedCoef", "SpeedCoef" + to);
            line = line.Replace("SpeedCoef2", "SpeedCoef2" + to);
            line = line.Replace("GetTempP1", "GetTempP1" + to);
            line = line.Replace("GetTempP2", "GetTempP2" + to);
            line = line.Replace("GetTempPk", "GetTempPk" + to);
            line = line.Replace("TempCoef", "TempCoef" + to);
            line = line.Replace("GetSeaP1", "GetSeaP1" + to);
            line = line.Replace("GetSeaP2", "GetSeaP2" + to);
            line = line.Replace("GetSeaPk", "GetSeaPk" + to);
            line = line.Replace("SolveCoeff", "SolveCoeff" + to);


            return line;
        }
        static void Main(string[] args)
        {
            string[] s = File.ReadAllLines("input.txt");
            StringBuilder final = new();
            string c1 = Console.ReadLine();

            foreach (var line in s)
            {
                string lineRes = Changing(line, "C1", c1);
                final.Append(lineRes);
                final.Append("\n");
            }

            File.WriteAllText("output.txt", final.ToString());
        }
    }
}
