namespace PPP_lab5
{
    internal class Dog : Pets
    {
        private int _runningSpeed;
        private int _withersHeightInCentimeters;
        private int _tailLengthInCentimeters;
        public static readonly int MAX_RUNNING_SPEED = 67;
        public static readonly int MIN_WITHERS_HEIGHT_IN_CENTIMETERS = 15;
        public static readonly int MAX_WITHERS_HEIGHT_IN_CENTIMETERS = 112;
        public static readonly int MAX_TAIL_LENGTH = 77;

        public int RunningSpeed 
        { 
            get => _runningSpeed; 
            set => _runningSpeed = value > 0 && value <= MAX_RUNNING_SPEED ? value : throw new ArgumentOutOfRangeException(); 
        }

        public int WithersHeightInCentimeters 
        { 
            get => _withersHeightInCentimeters; 
            set => _withersHeightInCentimeters = value > MIN_WITHERS_HEIGHT_IN_CENTIMETERS && value <= MAX_WITHERS_HEIGHT_IN_CENTIMETERS ? value : throw new ArgumentOutOfRangeException(); 
        }

        public int TailLengthInCentimeters 
        { 
            get => _tailLengthInCentimeters; 
            set => _tailLengthInCentimeters = value >= 0 && value <= MAX_TAIL_LENGTH ? value : throw new ArgumentOutOfRangeException(); 
        }

        /// <summary>
        /// Конструктор класса собаки
        /// </summary>
        /// <param name="name">Имя собаки. Должно быть не пустым</param>
        /// <param name="breed">Порода собаки. Должно быть не пустым</param>
        /// <param name="weightInGrams">Вес собаки в граммах. Больше 0 и меньше 155000</param>
        /// <param name="age">Возраст собаки. Больше нуля и меньше 69</param>
        /// <param name="coloring">Расцветка собаки. Должно быть не пустым</param>
        /// <param name="runningSpeed">Скорость бега собаки. Больше нуля и меньше 67 км/ч</param>
        /// <param name="withersHeightInCentimeters">Высота собаки в холке в сантиметрах. Больше 15 и меньше 112</param>
        /// <param name="tailLengthInCentimeters">Длина хвоста в сантиметрах. От 0 до 77</param>
        public Dog(string name, string breed, int weightInGrams, int age, string coloring, int runningSpeed, int withersHeightInCentimeters, int tailLengthInCentimeters) : base(name, breed, weightInGrams, age, coloring)
        {
            RunningSpeed = runningSpeed;
            WithersHeightInCentimeters = withersHeightInCentimeters;
            TailLengthInCentimeters = tailLengthInCentimeters;
        }

        public override string ToString()
        {
            return $"\nType of pet: Dog{base.ToString()}RunningSpeed: {RunningSpeed}, \nWithersHeightInCentimeters: {WithersHeightInCentimeters}, \nTailLengthInCentimeters: {TailLengthInCentimeters};\n";
        }
    }
}
