namespace _5138_OOP_Lesson1;

public abstract class Program {
    public static void Main(string[] text) {
        // Create family members
        AdultFamilyMember mother = new AdultFamilyMember(null, null, "Mary", Gender.Female, 35);
        AdultFamilyMember father = new AdultFamilyMember(null, null, "John", Gender.Male, 40);
        FamilyMember child1 = new FamilyMember(mother, father, "Emily", Gender.Female, 10);
        FamilyMember child2 = new FamilyMember(mother, father, "David", Gender.Male, 8);
        mother.Children = new[] { child1, child2 };
        father.Children = new[] { child1, child2 };

        // Create an adult family member with children
        AdultFamilyMember adult = new AdultFamilyMember(
            null,
            null,
            "Jane",
            Gender.Female,
            30,
            new FamilyMember[] { mother, father });

        // Print the family tree
        adult.Print();

        Console.ReadLine();
    }
}