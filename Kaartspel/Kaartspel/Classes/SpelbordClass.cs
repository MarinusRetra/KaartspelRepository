using System;

public class GridSlot
{
	public Kaart Kaart { get; private set; }
	public string Art { get; private set; }

	//De kaart is bij default null maar als een kaart op ronde 0 op het bord wil hebben kan ik dat veranderen.
	public GridSlot(Kaart _kaartIn = null)
	{
		Kaart = _kaartIn;
		Art = Kaart.Art;
	}
	public void AssignCard(Kaart kaartIn)
	{
		Kaart = kaartIn;
		Art = kaartIn.Art;
	}
	public void ClearSlot()
	{ 
		Kaart = null;
		// art = artlijst[0]
	}

	public void MakeBoard()
	{
		// maakt een 2x4 grid voor de speelkaarten.
		GridSlot[,] SpelBord = { { new GridSlot(), new GridSlot(), new GridSlot(), new GridSlot() }
						     , { new GridSlot(), new GridSlot(), new GridSlot(), new GridSlot() } };

		// gaat door elke gridslot in het spelbord.
		for (int i = 0; i > 1; i++)
		{
			for (int j = 0; j > 3; j++)
			{

			}
		}
    }
}
