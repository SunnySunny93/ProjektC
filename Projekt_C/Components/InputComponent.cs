using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace Projekt_C
{
	internal class InputComponent : GameComponent	///Internal: kann nur im gleichen Assembly genutzt werden.
	{
		public Vector2 Direction
		{
			get;
			private set;
		}

		public InputComponent(Game1 game) : base(game)
		{
		}

		public override void Update(GameTime gameTime)
		{
			///Gamepad Steuerung
			GamePadState state = GamePad.GetState(PlayerIndex.One); ///PlayerIndex: Gitb an welcher Spieler an der Reihe ist (1-4)
			Direction = state.ThumbSticks.Left * new Vector2(1f, -1f);

			base.Update(gameTime);
		}
	}
}