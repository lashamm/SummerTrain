namespace SummerTrain
{

    internal class Cars
    {
        public string Mark { get; set; }
        public string Model { get; set; }
        public int Horsepower { get; set; }
        public string Color { get; set; }
        public int Number { get; set; }
        public string ClassRacer { get; set; }

        public Cars() { }
        public Cars(
            string mark,
            string model,
            int horsepower,
            string color,
            int number,
            string classRacer
            )
        {
            Mark = mark;
            Model = model;
            Horsepower = horsepower;
            Color = color;
            Number = number;
            ClassRacer = classRacer;
        }

        public int hpTest()
        {
            if (Horsepower <= 0)
            {
                throw new ArgumentException("Horsepower must be a positive number.");
            }
            else
            {
                return Horsepower;
            }
        }

        public string classification()
        {
            if (Horsepower <= 0)
            {
                throw new ArgumentException("Horsepower must be a positive number.");
            }
            if (Horsepower <= 300)
            {
                ClassRacer = "Beginner Class";
            }
            else if (Horsepower > 300 && Horsepower < 600)
            {
                ClassRacer = "Semi-Pro Class";
            }
            else if (Horsepower >= 600)
            {
                ClassRacer = "Pro Class";
            }
            return ClassRacer;
        }

        public void PrintInfo()
        {
            Console.WriteLine(
                $"Mark: {Mark}" +
                $"\nModel: {Model}" +
                $"\nHorsepower: {hpTest()} HP" +
                $"\nColor: {Color}" +
                $"\nNumber: {Number}" +
                $"\nClass: {classification()}");
        }
    }

}