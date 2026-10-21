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
    Console.WriteLine("********název programu*******");
    Console.WriteLine("*****************************");

    

    //načtení první hodnoty
    Console.Write("Zadejte první číslo: ");
    int aaa;
    // ! znamená negace 
    while(!int.TryParse(Console.ReadLine(), out aaa))
    {
        Console.Write("Nezadali jste číslo. Zadejte číslo znovu: ");
    }
        
    // načtení druhé hodnoty 
    Console.Write("Zadejte další číslo: ");
    int bbb;
    // ! znamená negace 
    while(!int.TryParse(Console.ReadLine(), out bbb))
    {
        Console.Write("Nezadali jste číslo. Zadejte číslo znovu: ");
    }

   
    //rekapitulace zadaných hodnot
    Console.WriteLine();
    Console.WriteLine("===================");
    Console.WriteLine($"První číslo: {aaa}");
    Console.WriteLine($"Druhé číslo: {bbb}");
    Console.WriteLine("===================");
    Console.WriteLine();
    

    //zde budeme pokračovat konkrétním algoritmem
   


    // Dotez směrem k uživateli na opakování
    Console.WriteLine();
    Console.Write("pro opakování programu stiskněte klávesu a. Následně podvrďte klávesou enter.");
    again = Console.ReadLine() ?? "";
}
    
