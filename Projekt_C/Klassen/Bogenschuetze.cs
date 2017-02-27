using System;
using System.Collections.Generic;

namespace Projekt_C.Klassen
{
	//Spielcharakter
	internal class Bogenschuetze : Character, IAttackable, IAttacker, IInteractor
	{
		//Maximales Leben
		public int MaxHitpoints
		{
			get;
			set;
		}

		//Noch verfügbares Leben
		public int Hitpoints
		{
			get;
			set;
		}

		//Liste alle angreifbaren Objekte in der Nähe
		public ICollection<Item> AttackableItems
		{
			get;
			private set;
		}

		//Radius zum Angreifen von Objekten
		public float AttackRange
		{
			get;
			set;
		}

		//Höhe der Angriffe
		public int AttackValue
		{
			get;
			set;
		}

		//Liste der Objekte, mit denen interagiert werden können
		public ICollection<Item> InteractableItems
		{
			get;
			private set;
		}

		//Interaktionsradius
		public float InteractionRange
		{
			get;
			set;
		}

		//Größere Angriffs-Reichweite
		public Bogenschuetze()
		{
			AttackableItems = new List<Item>();
			InteractableItems = new List<Item>();
			MaxHitpoints = 4;
			Hitpoints = 4;
			AttackRange = 1.5f;
			AttackValue = 1;
			InteractionRange = 0.5f;
		}
	}
}

