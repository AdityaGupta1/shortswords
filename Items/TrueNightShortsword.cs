using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Shortswords.Projectiles;

namespace Shortswords.Items {
    public class TrueNightShortsword : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("True Night Knife");
            Tooltip.SetDefault("'Night knife.'");
        }

        public override void SetDefaults() {
            item.damage = 78;
            item.useStyle = 5;
            item.useAnimation = 18;
            item.useTime = 14;
            item.shootSpeed = 2.5f;
            item.knockBack = 4.5f;
            item.width = 36;
            item.height = 38;
            item.rare = 8;
            item.UseSound = SoundID.Item1;
            item.shoot = mod.ProjectileType<TrueNightProjectile>();
            item.value = 400000;
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
            recipe.AddIngredient(null, "NightShortsword", 1);
            recipe.AddIngredient(ItemID.BrokenHeroSword, 1);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
