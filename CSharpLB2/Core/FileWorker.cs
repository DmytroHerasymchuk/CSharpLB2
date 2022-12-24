using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using CSharpLB2.Models;
using Newtonsoft.Json;

namespace CSharpLB2.Core
{
    public static class FileWorker
    {
        private static string _path = "ShopData";
        public static void CreateDirectory()
        {
            if (!Directory.Exists(_path)) { 
                Directory.CreateDirectory(_path); 
            }         
        }

        public static void CreateFile(string fileName)
        {
            if (!File.Exists($"{_path}\\{fileName}.txt"))
            {
                File.Create($"{_path}\\{fileName}.txt");
            }           
        }

        public static void Write(List<Car> cars, string fileName)
        {
            foreach(Car car in cars)
            {
                Read(($"{_path}\\{fileName}.txt"));
                string json = JsonConvert.SerializeObject(car);

                FileStream fileStream = new FileStream(fileName, FileMode.OpenOrCreate);
                
                File.WriteAllText($"{_path}\\{fileName}.txt", json);
            }
            
        }

        public static List<Car> Read(string fileName)
        {
            string json = File.ReadAllText(fileName);

            List<Car> cars = JsonConvert.DeserializeObject<List<Car>>(json);
            return cars;
        }
    }
}
