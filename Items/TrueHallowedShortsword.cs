using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Shortswords.Projectiles;

namespace Shortswords.Items {
    public class TrueHallowedShortsword : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("True Excali-stab-bur");
            Tooltip.SetDefault("'Break the stone that once held it'");
        }

        public override void SetDefaults() {
            item.damage = 60;
            item.useStyle = 5;
            item.useAnimation = 18;
            item.useTime = 9;
            item.shootSpeed = 3f;
            item.knockBack = 4.5f;
            item.width = 48;
            item.height = 48;
            item.rare = 8;
            item.UseSound = SoundID.Item1;
            item.shoot = mod.ProjectileType<TrueHallowedProjectile>();
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
            recipe.AddIngredient(null, "HallowedShortsword", 1);
            recipe.AddIngredient(ItemID.BrokenHeroSword, 1);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
