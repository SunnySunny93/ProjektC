using System;

namespace Projekt_C.Klassen
{
	// Repräsentiert eine Kachel einer Area.
	internal class Tile
	{
		// Gibt an ob diese Tile den Spieler an der Bewegung hindert.
		public bool Blocked 
		{ 
			get; 
			set; 
		}

		public Tile()
		{
		}
	}
}

