using System;
using System.Collections.Generic;

namespace Projekt_C.Klassen
{
	internal class World
	{
		public List<Area> Areas 
		{ 
			get; 
			private set; 
		}

		public World()
		{
			Areas = new List<Area>();
		}
	}
}
