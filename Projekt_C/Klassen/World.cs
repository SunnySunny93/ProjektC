﻿using System;
namespace Projekt_C
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
