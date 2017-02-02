using System;

namespace Projekt_C.Klassen
{
	//Interface für alle angreifbaren Objekten
	internal interface IAttackable
	{
		//Maximales Leben
		int MaxHitpoints 
		{ 
			get; 
		}

		//Anzahl noch vorhandenes Leben
		int Hitpoints 
		{ 
			get; 
		}
	}
}

