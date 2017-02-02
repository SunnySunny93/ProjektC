using System;
using Microsoft.Xna.Framework;

namespace Projekt_C.Klassen
{
	//Klasse für alle bewegbaren Spieleinheiten
	internal class Character : Item
	{
		//Gesxchwindigkeit, mit der sich das Objekt fortbewegen kann
		public Vector2 Velocity 
		{ 
			get; 
			set; 
		}

		public Character()
		{
		}
	}
}

