using System;

namespace Projekt_C.Klassen
{
	//Interface für alle Items
	internal interface ICollidable
	{
		//Masse der Items
		float Mass 
		{ 
			get; 
		}

		//Bewegbares Item?
		bool Fixed 
		{ 
			get; 
		}
	}
}

