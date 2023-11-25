using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GameStudent
{
    class Student : IExecuteCommands
    {


        public string name;
        private string _name
        { 
            get { return name; } 
            set { name = value; }

        }
        
        public int age;
        private int _age
        {
            get { return age; }
            set { age = value; }
        }
        public bool checkAge = false;
        public int hp; //вот это private
        private int _hp //вот это publ
        {
            get { return hp; }
            set { hp = value; }
        }
        
        public string gender;
        private string _gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public int GenderCheck { get; set; }

        public int energy;
        private int _energy
        {
            get { return energy; }
            set { energy = value; }
        }
        public int iq;
        private int _iq
        {
            get { return iq; }
            set { iq = value; }
        }
        public int _genderCheck;
        public Student()
        {
        }
        public Student(string Name, int Age, int hP, string Gender, int Energy, int IQ, int genderCheck)
        {
            name = Name;
            age = Age;
            hP = 100;
            hp = hP;
            gender = Gender;
            energy = 50;
            _energy = Energy;
            IQ = 100;
            iq = IQ;
            GenderCheck = genderCheck;
        }
        public string PrintCommand()
        {
            short command;
            do
            {
                command = Convert.ToInt16(Console.ReadLine());
                switch (command)
                {
                    case 1:
                        ShowData();
                        return GoSleep();

                    case 2:
                        ShowData();
                        return Run();
                    case 3:
                        ShowData();
                        return GoStudy();
                    case 4:
                        ShowData();
                        return Eating();
                    case 5:
                        ShowData();
                        return GoWalk();
                }
            }
            while (command != 6);
            return "";
        }
        public string GoWalk()
        {
            energy -= 10;
            return $"{name} гуляет. " +
                $"-10 ед. энергии";
        }

        public string GoSleep()
        {

            if ((energy < 50) || (hp < 100))
            {
                energy = 50;
                return $"{name} спит. " +
                    $"Полное восстановление энергии и здоровья";
            }
            else
                return $"{name} спит. " +
                    $"Восстановление энергии не требуется";
        }

        public string Eating()
        {
            if (hp < 100)
            {
                hp += 20;
            }
            return $"{name} перекусывает. ";
        }

        public string GoStudy()
        {
            _iq += 15;
            if(energy > 5 )
            {
                energy -= 5;
            }
            return $"{name} читает. Это повышает интеллект";
        }

        public string Run()
        {
            if (energy < 20)
            {
                return $"{name}, Бег невозможет - нехватка енергии. Восстановите её с помощью сна или перекуса.";
            }
            else
            {
                energy -= 20;
                return $"{name}, бегает. " +
                    $"Сжигается 20 ед. энергии";
            }
        }
        public void GetName()
        {
            name = Console.ReadLine();
            if(!(name is string))
            {
                Console.WriteLine("Пожалуйста, введите обычное имя");  
                GetName();
            }
            
        }
        public void Registrate()
        {
            Console.WriteLine("Добро пожаловать в игру про студента. Введите имя Вашего персонажа.");

        }
        public void GetAge()
        {
            Console.WriteLine($"{name}, введите возраст Вашего персонажа.");
            for (int i = 0; checkAge == false; i++)
            {
                try
                {
                    age = Convert.ToInt32(Console.ReadLine());
                }
                catch(FormatException)
                {
                    Console.WriteLine("Введите число");
                }
                if (age < 7)
                {
                    Console.WriteLine("Пожалуйста, введите реалистичный возраст, персонаж такого возраста слишком мал для того, чтобы быть студентом.");
                    age = 0;
                }
                else if (age > 100)
                {
                    Console.WriteLine("Пожалуйста, введите реалистичный возраст, персонаж такого возраста слишком стар ");
                    age = 0;
                }
                else
                {
                    age = _age;
                    checkAge = true;
                    Console.WriteLine("Отличный возраст! Идём дальше.");

                }
            }
        }
        public void GetGender()
        {
            Console.WriteLine("Выберите пол Вашего персонажа: 1 - Мужской, 2 - Женский");
            
                _genderCheck = Convert.ToInt16(Console.ReadLine());
                if (_genderCheck == 1)
                {
                    gender = "Мужской";
                }
                else if (_genderCheck == 2)
                {
                    gender = "Женский";
                }
                else
                {
                    Console.WriteLine("Выберите один из предложенных вариантов, пожалуйста");
                    GetGender();
                }
        }
        public void None()
        {
            Console.WriteLine("Выбирайте, чем хотите заняться.  1 - Спать  2 - Побегать  3 - Почитать  4 - Поесть 5 - Погулять 6 - Завершить игру");
        }
        public string ShowData() 
        {
            return($"Имя: {name}, Возраст: {age}, Здоровье: {hp}, Пол: {gender}, Энергия: {energy}, Интеллект: {iq}");
        }
    }
    /*enum StudentState
    {
        Registration,
        Name,
        Gender,
        Age,
        Non,
        Eat,
        Walk,
        Read,
        Sleep,
        Run
    }*/
}
