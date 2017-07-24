using Terraria;
using Terraria.ID;
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

		public override void AddRecipeGroups()
		{
			RecipeGroup group;

			group = new RecipeGroup(() => "Palladium or Cobalt Bar", new int[]
			{
				ItemID.PalladiumBar,
				ItemID.CobaltBar
			});
			RecipeGroup.RegisterGroup("Shortswords:HardmodeOres1", group);

			group = new RecipeGroup(() => "Mythril or Orichalcum Bar", new int[]
			{
				ItemID.MythrilBar,
				ItemID.OrichalcumBar
			});
			RecipeGroup.RegisterGroup("Shortswords:HardmodeOres2", group);

			group = new RecipeGroup(() => "Titanium or Adamantite Bar", new int[]
			{
				ItemID.TitaniumBar,
				ItemID.AdamantiteBar
			});
			RecipeGroup.RegisterGroup("Shortswords:HardmodeOres3", group);
		}
	}
}
