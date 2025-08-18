namespace SummerTrain
{

    internal class cars
    {
        public int mark { get; set; }
        public string model { get; set; }
        public int horsepower { get; set; }
        public string color { get; set; }
        public int number { get; set; }
        public string classRacer { get; set; }

        public cars() { }
        public cars(
            int mark,
            string model,
            int horsepower,
            string color,
            int number,
            string classRacer
            )
        {
            this.mark = mark;
            this.model = model;
            this.horsepower = horsepower;
            this.color = color;
            this.number = number;
            this.classRacer = classRacer;
        }

        public int hpTest()
        {
            if (horsepower <= 0)
            {
                throw new ArgumentException("Horsepower must be a positive number.");
            }
            else
            {
                return horsepower;
            }
        }

        public string classification()
        {
            if (horsepower <= 0)
            {
                throw new ArgumentException("Horsepower must be a positive number.");
            }
            if (horsepower <= 300)
            {
                classRacer = "Beginner Class";
            }
            else if (horsepower > 300 || horsepower < 600)
            {
                classRacer = "Semi-Pro Class";
            }
            else if (horsepower >= 600)
            {
                classRacer = "Pro Class";
            }
            return classRacer;
        }

        public void PrintInfo()
        {
            Console.WriteLine(
                $"Mark: {mark}" +
                $"\nModel: {model}" +
                $"\nHorsepower: {hpTest()} HP" +
                $"\nColor: {color}" +
                $"\nNumber: {number}" +
                $"\nClass: {classification()}");
        }
    }

}