using Terraria.ModLoader;
using System;

namespace Shortswords
{
	class Shortswords : Mod
	{
		public static Random random = new Random();

		public Shortswords()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
