using System;
using System.Collections.Generic;

namespace Projekt_C.Klassen
{
	//Interface für alle aktiven Angreifer
	internal interface IAttacker
	{
		//Liste mit allen angreifbaren Objekten
		ICollection<Item> AttackableItems 
		{ 
			get; 
		}

		//Angriffsradius
		float AttackRange 
		{ 
			get; 
		}

		//Höhe der Angriffe
		int AttackValue 
		{ 
			get; 
		}
	}
}

