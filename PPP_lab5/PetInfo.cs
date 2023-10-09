namespace PPP_lab5
{
    public class PetInfo
    {
        private string _name;
        private string _breed;
        private int _weightInGrams;
        private int _age;
        private string _coloring;
        public static readonly int MAX_WEIGHT_IN_GRAMS = 155000;
        public static readonly int MAX_AGE = 69;

        public string Name 
        { 
            get => _name; 
            set => _name = !string.IsNullOrEmpty(value) ? value.Trim() : throw new Exception("Строка пуста или равна null."); 
        }

        public string Breed 
        { 
            get => _breed; 
            set => _breed = !string.IsNullOrEmpty(value) ? value.Trim() : throw new Exception("Строка пуста или равна null."); 
        }

        public int WeightInGrams 
        { 
            get => _weightInGrams; 
            set => _weightInGrams = value > 0 && value <= MAX_WEIGHT_IN_GRAMS ? value : throw new ArgumentOutOfRangeException(); 
        }

        public int Age 
        { 
            get => _age; 
            set => _age = value > 0 && value <= MAX_AGE ? value : throw new ArgumentOutOfRangeException(); 
        }

        public string Coloring 
        { 
            get => _coloring; 
            set => _coloring = !string.IsNullOrEmpty(value) ? value.Trim() : throw new Exception("Строка пуста или равна null."); 
        }

        /// <summary>
        /// Конструктор класса информации о питомце
        /// </summary>
        /// <param name="name">Имя питомца. Должно быть не пустым</param>
        /// <param name="breed">Порода питомца. Должно быть не пустым</param>
        /// <param name="weightInGrams">Вес питомца в граммах. Больше 0 и меньше 155000</param>
        /// <param name="age">Возраст питомца. Больше нуля и меньше 69</param>
        /// <param name="coloring">Расцветка питомца. Должно быть не пустым</param>
        public PetInfo(string name, string breed, int weightInGrams, int age, string coloring)
        {
            Name = name;
            Breed = breed;
            WeightInGrams = weightInGrams;
            Age = age;
            Coloring = coloring;
        }

        public override string ToString()
        {
            return $"\nName: {Name}, \nBreed: {Breed}, \nWeightInGrams: {WeightInGrams}, \nAge: {Age}, \nColoring: {Coloring},\n";
        }
    }
}
