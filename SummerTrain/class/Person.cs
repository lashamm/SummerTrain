namespace SummerTrain
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Age { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }


        public Person() { }
        public Person(
            int id,
            string name,
            string surname,
            DateTime age,
            string gender,
            string email
            )
        {
            Id = id;
            Name = name;
            Surname = surname;
            Age = age;
            Gender = gender;
            Email = email;
        }

        public int calculateAge()
        {
            if (Age > DateTime.Now)
            {
                throw new ArgumentException("Age cannot be in the future.");
            }
            int ageYears = DateTime.Now.Year - Age.Year;
            if (Age.DayOfYear > DateTime.Now.DayOfYear)
            {
                ageYears--;
            }
            return ageYears;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Id: {Id}" +
                $"\nName: {Name}" +
                $"\nSurname: {Surname}" +
                $"\nAge: {calculateAge()} years old" +
                $"\nEmail: {Email}" +
                $"\nGender: {Gender}");
        }
    }
}