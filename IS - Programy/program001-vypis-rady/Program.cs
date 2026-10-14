string again = "a";

// řídící cyklus programu
/* ToLower() převede vstup na malá písmena, takže program pokračuje při zadání "a" i "A" */
// jakýkoli jiný vstup program ukončí
while(again.ToLower() == "a")
{
    //hlavička programu Console.Clear -> vymazání obrazovky
    Console.Clear();
    Console.WriteLine("*****************************");
    Console.WriteLine("********Simona Veselá********");
    Console.WriteLine("*****************************");
    Console.WriteLine("**********výpis řady*********");
    Console.WriteLine("*****************************");

    //vstup počáteční hodnoty
    




    // Dotez směrem k uživateli na opakování
    Console.WriteLine();
    Console.Write("pro opakování programu stiskněte klávesu a. Následně podvrďte klávesou enter.");
    again = Console.ReadLine() ?? "";
}
