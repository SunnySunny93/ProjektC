using System;
using Microsoft.Xna.Framework;

namespace Projekt_C.Klassen
{
	//Basisklasse fpr alle Items auf dem Spielfeld
	internal class Item : ICollidable
	{
		// Internes Feld zur Haltung des temporären Move-Vektors.
		internal Vector2 move = Vector2.Zero;

		//Masse des Items
		public float Mass 
		{ 
			get; 
			set; 
		}

		// Item bewegbar oder nicht
		public bool Fixed 
		{ 
			get; 
			set; 
		}

		//Position des Items
		public Vector2 Position 
		{ 
			get; 
			set; 
		}

		//Kollisionsradius des Items
		public float Radius 
		{ 
			get; 
			set; 
		}

		public Item()
		{
			// Standard-Werte für alle Items
			Fixed = false;
			Mass = 1f;
		}
	}
}