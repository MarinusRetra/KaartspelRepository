using System;
/* Wat zit er in elk kaart object:
 * 1 Hp en damage
 * 2 Speciale kaart abilities
 * 3 Een reference naar de passende asci art
 * 4 De positie van de kaart op het spelbord
 * 5 De kaart naam
 */
public abstract class Kaarten
{
	public string? Name { get; protected set; }
	public int Health { get; protected set; }
	public int Damage { get; protected set; }

	public virtual void TakeDamage(Kaart attacker)
	{
		Health -= attacker.Damage;
	}
	public virtual void Die() 
	{
		//wipe de data van het slot dat deze kaart ingebruik neemt	
	}
	public virtual void Attack(List<Kaart> targetKaarten) 
	{ 
		
	}
}

public class Kaart : Kaarten
{ 
	public Kaart(int _healtIn, int _DamageIn, string _nameIn)
	{ 
		Health = _healtIn;
		Damage = _DamageIn;
		Name = _nameIn;
	}
}
