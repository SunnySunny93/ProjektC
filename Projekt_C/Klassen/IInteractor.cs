using System;
using System.Collections.Generic;

namespace Projekt_C.Klassen
{
	//Interface für alle Charactere, die mit Items interagieren
	internal interface IInteractor
	{
		//Liste mit allen Items im Interaktionsradius
		ICollection<Item> InteractableItems 
		{ 
			get; 
		}

		//Interaktionsradius
		float InteractionRange 
		{ 
			get; 
		}
	}
}

