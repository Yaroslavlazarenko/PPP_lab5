namespace PPP_lab5
{
    public class Pets
    {
        private PetInfo _petInfo;

        public Pets(string name, string breed, int weightInGrams, int age, string coloring)
        {
            _petInfo = new PetInfo(name, breed, weightInGrams, age, coloring);
        }

        public override string ToString()
        {
            return $"{_petInfo}";
        }
    }
}
