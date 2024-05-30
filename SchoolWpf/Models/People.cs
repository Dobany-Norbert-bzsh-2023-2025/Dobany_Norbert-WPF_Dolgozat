using SchoolWpf.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SchoolWpf.Models
{
    public class People
    {
        /*private int id;

        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged();
            }
        }


        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged();
            }
        }

        private int age;

        public int Age
        {
            get { return age; }
            set
            {
                age = value;
                OnPropertyChanged();
            }
        }

        private string city;

        public string City
        {
            get { return city; }
            set
            {
                city = value;
                OnPropertyChanged();
            }
        }

        private string occupation;

        public string Occupation
        {
            get { return occupation; }
            set
            {
                occupation = value;
                OnPropertyChanged();
            }
        }

        private string hobbies;

        public string Hobbies
        {
            get { return hobbies; }
            set
            {
                hobbies = value;
                OnPropertyChanged();
            }
        }


        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public People()
        {

        }

        public People(string name, int age, string city, string occupation, string hobbies)
        {
            Id = 0;
            Name = name;
            Age = age;
            City = city;
            Occupation = occupation;
            Hobbies = hobbies;
        }*/

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public string Occupation { get; set; }
        public string Hobbies { get; set; }


        public People()
        {
        }

        public People(string sor)
        {
            string[] t = sor.Split(';');
            Name = t[0];
            Age = Convert.ToInt32(t[1]);
            City = t[2];
            Occupation = t[3];
            Hobbies = t[4];
        }

        public override string? ToString()
        {
            return $"Név: {Name}";
        }
    }
}
