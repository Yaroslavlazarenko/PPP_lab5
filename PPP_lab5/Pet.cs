namespace PPP_lab5
{
    public class Pet
    {
        private PetInfo _petInfo;

        public Pet(string name, string breed, int weightInGrams, int age, string coloring)
        {
            _petInfo = new PetInfo(name, breed, weightInGrams, age, coloring);
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
            return $"{_petInfo}";
        }
    }
}
