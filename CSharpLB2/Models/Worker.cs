using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpLB2.Models.WorkerEnums;

namespace CSharpLB2.Models
{
    public class Worker
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string IPN { get; set; }
        public Education Education { get; set; }
        public Position Position { get; set; }
        public DateTime Birthday { get; set; }
        public int Salary
        {
            get
            {
                return Salary;
            }
            set
            {
                if(value >= 8000 && value <= 60000)
                {
                    Salary = value; 
                }
            }
        }

        public Worker(string name, string lastName, Education education, Position position, DateTime birthday, int salary)
        {
            Name = name;
            LastName = lastName;
            IPN = GenerateIPN();
            Education = education;
            Position = position;
            Birthday = birthday;
            Salary = salary;
        }

        private string GenerateIPN()
        {
            Random random = new Random();
            string numbers = "0123456789";
            var buffer = new char[10];
            for (int i = 0; i < 10; i++)
            {
                buffer[i] = numbers[random.Next(numbers.Length)];
            }
            return buffer.ToString();
        }
    }
}
