/* Wat zit er in elk kaart object:
 * 1 Hp en damage
 * 2 Speciale kaart abilities
 * 3 Een reference naar de passende asci art
 * 4 De positie van de kaart op het spelbord
 * 5 De kaart naam
 */
public class Kaart
{
	public string Art { get; private set; }
	public string? Name { get; private set; }
	public int Health { get; private set; }
	public int Damage { get; private set; }

	public Kaart()
	{
		Health = -1;
		Damage = -1;
		Name = string.Empty;
		Art = ArtClass.BlankArt;
	}
	public Kaart(int _healtIn, int _DamageIn, string _nameIn, string _artIn)
	{ 
		Health = _healtIn;
		Damage = _DamageIn;
		Name = _nameIn;
		Art = _artIn;
	}
	public virtual void TakeDamage(int damageIn)
	{
		Health -= damageIn;
		if (Health <= 0)
		{
			Die();
		}
	}
	public virtual void Die() 
	{
		//wipe de data van het slot dat deze kaart ingebruik neemt	
	}
	public virtual void Attack(List<Kaart> targetKaarten)
	{
		foreach(Kaart doelwit in targetKaarten)
		{
			doelwit.TakeDamage(Damage);
		}
	}

	public void SetArt(string artIn)
	{ 
		Art = artIn;
	}
}

