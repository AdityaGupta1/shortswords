using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Shortswords.Projectiles;

namespace Shortswords.Items
{
	public class LunarShortsword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Lunar Lance");
			Tooltip.SetDefault("'A fragment of the Moon Lord's power'");
		}
		public override void SetDefaults()
		{
			item.damage = 165;
			item.useStyle = 5;
			item.useAnimation = 18;
			item.useTime = 30;
			item.shootSpeed = 3.7f;
			item.knockBack = 7f;
			item.width = 32;
			item.height = 32;
			item.rare = 10;
			item.UseSound = SoundID.Item1;
			item.shoot = mod.ProjectileType<LunarProjectile>();
			item.value = 2500000;
			item.noMelee = true;
			item.noUseGraphic = true;
			item.melee = true;
			item.autoReuse = true;
		}

		public override bool CanUseItem(Player player)
		{
			return player.ownedProjectileCounts[item.shoot] < 1;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "SolarShortsword", 1);
			recipe.AddIngredient(ItemID.LunarBar, 8);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
