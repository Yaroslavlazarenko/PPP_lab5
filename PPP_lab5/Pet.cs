namespace PPP_lab5
{
    public class Pet
    {
        private PetInfo _petInfo;
        private string _gender;

        /// <summary>
        /// Получить или записать гендер. Гендеры бывают разные, их очень много, поэтому строка только не должна быть пустой.
        /// </summary>
        public string Gender { 
            get => _gender; 
            set => _gender = !string.IsNullOrEmpty(value) ? value.Trim() : throw new Exception("Строка пуста или равна null.") ; 
        }

        /// <summary>
        /// Конструктор класса пета
        /// </summary>
        /// <param name="name">Имя питомца</param>
        /// <param name="breed">Порода питомца</param>
        /// <param name="weightInGrams">Вес питомца в граммах</param>
        /// <param name="age">Возраст питомца</param>
        /// <param name="coloring">Расскраска питомца</param>
        /// <param name="gender">Гендер питомца</param>
        public Pet(string name, string breed, int weightInGrams, int age, string coloring, string gender)
        {
            _petInfo = new PetInfo(name, breed, weightInGrams, age, coloring);
            Gender = gender;
        }

        /// <summary>
        /// Получить базовую информацию о питомце.
        /// </summary>
        public PetInfo petInfo
        {
            get => _petInfo;
        }

        public override string ToString()
        {
            return $"{_petInfo}Gender: {Gender},\n";
        }
    }
}
