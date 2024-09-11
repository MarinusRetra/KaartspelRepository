		
        
public class GridSlot
{
	public Kaart Kaart { get; private set; }
	public string Art { get; private set; }

	//De kaart is bij default null maar als een kaart op ronde 0 op het bord wil hebben kan ik dat veranderen.
	public GridSlot(Kaart _kaartIn)
	{
		Kaart = _kaartIn;
		if (Kaart != null)
		{
			Art = Kaart.Art;
		}
	}
	public void AssignCard(Kaart kaartIn)
	{
		Kaart = kaartIn;
		Art = kaartIn.Art;
	}
	public void ClearSlot()
	{ 
		Kaart = null;
		Art = ArtClass.BlankArt;
	}
	
    /// <summary>
	/// maakt een 2x4 grid voor de speelkaarten.
	/// </summary>
	public static void MakeBoard()
	{
        GridSlot[,] SpelBord = { { new GridSlot(new()), new GridSlot(new()), new GridSlot(new()), new GridSlot(new()) }
                              ,{new GridSlot(new()), new GridSlot(new()), new GridSlot(new()), new GridSlot(new())} };
		
		PrintBord(SpelBord);
    }
	/// <summary>
	/// gaat door elke gridslot in het spelbord.
	/// </summary>
	/// <param name="SpelBord"></param>
	public static void PrintBord(GridSlot[,] SpelBord)
	{ 
		Console.SetCursorPosition(Console.WindowWidth/2, Console.WindowHeight/2);
		for (int i = 0; i < SpelBord.GetLength(0); i++)
		{
			for (int j = 0; j < SpelBord.GetLength(1); j++)
			{
				Console.Write(SpelBord[i, j].Art);
				Console.Write(" ");
            }
			int x = Console.GetCursorPosition().Left;
			int y = Console.GetCursorPosition().Top;
			Console.WriteLine();
            Console.WriteLine();
			Console.SetCursorPosition(x-SpelBord.GetLength(0)*4, y+2);
			//TODO verander dit later om met de kaart art te scalen
        }
	}
}
