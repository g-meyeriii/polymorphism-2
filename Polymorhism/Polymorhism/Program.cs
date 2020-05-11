using System;
using System.IO;

namespace Polymorhism
{
    class Program
    {
        static void Main(string[] args)
        {
            //var cars = new List<Car>
            //{
            //    new Audi ("A4", 200, "blue"),
            //    new BMW ("M3", 250,"red")
            //};

            //foreach(var car in cars)
            //{
            //    car.Repair();


            //}

            //Car bmwZ3 = new BMW("Z3", 200, "black");
            //Car audiA3 = new Audi("A3", 100, "purple");

            //bmwZ3.ShowDetails();
            //audiA3.ShowDetails();

            //bmwZ3.SetCarIdInfo(1234, "Joe Bob");
            //audiA3.SetCarIdInfo(1235, "Billy Bob");

            //bmwZ3.GetCarIdInfo();
            //audiA3.GetCarIdInfo();

            //BMW bmwM5 = new BMW("M5", 300, "yellow");
            //bmwM5.ShowDetails();

            //Car carB = (Car)bmwM5;

            //carB.ShowDetails();

            //M3 m3 = new M3("M3 super turbo", 260, "red");

            //m3.Repair();


            ////Example one reading from txt file
            //string text = System.IO.File.ReadAllText(@"C:\Users\gjmii\OneDrive\Desktop\text.txt" );

            //Console.WriteLine("Text file contains following text:  {0}", text);

            ////Example two reading from a txt file
            //string[] lines = System.IO.File.ReadAllLines(@"C:\Users\gjmii\OneDrive\Desktop\text.txt");

            //Console.WriteLine("Contents of textfile.txt = ");
            //foreach(string line in lines)
            //{
            //    Console.WriteLine("\t" + line);
            //}


            //Method 1 of writting into a txt file
            string[] lines = { "First 250", "Second 242", "Third 240" };
            File.WriteAllLines(@"C:\Users\gjmii\OneDrive\Desktop\highscores.txt", lines);

            ////Method 2 of writting into a txt file
            //Console.WriteLine("Please give the file a name.");
            //string fileName = Console.ReadLine();
            //Console.WriteLine("Please add file txt.");
            //string input = Console.ReadLine();

            //File.WriteAllText(@"C:\Users\gjmii\OneDrive\Desktop\" + fileName + ".txt", input);

            //Method 3 writting into a txt file
            using(StreamWriter file = new StreamWriter(@"C:\Users\gjmii\OneDrive\Desktop\myText.txt"))
            {
                foreach(string line in lines)
                {
                    if (line.Contains("Third"))
                    {
                        file.WriteLine(line);
                    }
                }
            }
            using (StreamWriter file = new StreamWriter(@"C:\Users\gjmii\OneDrive\Desktop\myText2.txt"))
            {
                foreach (string line in lines)
                {
                    if (line.Contains("2"))
                    {
                        file.WriteLine(line);
                    }
                }
            }

            using(StreamWriter file = new StreamWriter(@"C:\Users\gjmii\OneDrive\Desktop\myText2.txt",true))
            {
                file.WriteLine("Additional line");
            }
        }
    }
}
