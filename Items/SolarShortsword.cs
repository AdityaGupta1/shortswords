using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Shortswords.Projectiles;

namespace Shortswords.Items {
    public class SolarShortsword : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Solar Stabber");
            Tooltip.SetDefault("'Unleash the power of the stars'");
        }

        public override void SetDefaults() {
            item.damage = 140;
            item.useStyle = 5;
            item.useAnimation = 18;
            item.useTime = 24;
            item.shootSpeed = 3.7f;
            item.knockBack = 6f;
            item.width = 32;
            item.height = 32;
            item.scale = 1f;
            item.rare = 10;
            item.UseSound = SoundID.Item1;
            item.shoot = mod.ProjectileType<SolarProjectile>();
            item.value = 500000;
            item.noMelee = true;
            item.noUseGraphic = true;
            item.melee = true;
            item.autoReuse = true;
        }

        public override bool CanUseItem(Player player) {
            return player.ownedProjectileCounts[item.shoot] < 1;
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.FragmentSolar, 14);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
