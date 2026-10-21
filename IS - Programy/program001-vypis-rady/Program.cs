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

    //vstup počáteční hodnoty špatně řešený
    //Console.Write("Zadejte první číslo řady");
    //int first = int.Parse(Console.ReadLine());

    //načtení počáteční hodnoty
    Console.Write("Zadejte první číslo řady (kladné celé číslo): ");
    int first;
    // ! znamená negace 
    while(!int.TryParse(Console.ReadLine(), out first))
    {
        Console.Write("Nezadali jste kladné celé číslo. Zadejte první číslo řady znovu: ");
    }
        
    // načtení koncové hodnoty řady
    Console.Write("Zadejte poslední číslo řady (kladné celé číslo): ");
    int last;
    // ! znamená negace 
    while(!int.TryParse(Console.ReadLine(), out last))
    {
        Console.Write("Nezadali jste kladné celé číslo. Zadejte poslední číslo řady znovu: ");
    }

    //načtení diference s kontrolou kladného čísla
    Console.Write("Zadejte diferenci (kladné celé číslo): ");
    int step;
    // ! znamená negace 
    while(!int.TryParse(Console.ReadLine(), out step) || step <=0 )
    {
        Console.Write("Nezadali jste kladné celé číslo. Zadejte difenenci znovu: ");
    }



    // Dotez směrem k uživateli na opakování
    Console.WriteLine();
    Console.Write("pro opakování programu stiskněte klávesu a. Následně podvrďte klávesou enter.");
    again = Console.ReadLine() ?? "";
}
