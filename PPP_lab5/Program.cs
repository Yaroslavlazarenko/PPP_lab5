namespace PPP_lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parrot parrot = new Parrot("Kesha", "Macaw", 1000, 5, "Bright red", "Male", 5, 2, 3);
            Cat cat = new Cat("Vasya", "Siamese", 4300, 2, "Orange", "Cisgender", 8, 42, 12);
            Dog dog = new Dog("Baron", "Labrador", 25000, 3, "Chocolate", "Genderfluid", 25, 60, 40);
            Dog dog1 = new Dog("Barsik", "Stray", 10000, 4, "Black", "Female", 20, 45, 20);

            Household household = new Household(parrot, cat, dog, dog1);

            Console.WriteLine($"Первоначальный список питомцев в домохозяйстве:\n{household}");

            household.AddPet(new Cat("Murzik", "Persian", 4500, 3, "Gray with white spots", "Male", 12, 15, 10));

            Console.WriteLine($"Список питомцев после добавления ещё одного:\n{household}");

            household.RemovePet(3);

            Console.WriteLine($"Список питомцев после удаления одного из них:\n{household}");

            household.EditPet(1, new Parrot("Coco", "Cockatoo", 1200, 20, "White", "Agender", 8, 5, 6));

            Console.WriteLine($"Список питомцев после изменения одного из них:\n{household}");
        }
    }
}