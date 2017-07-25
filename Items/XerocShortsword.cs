using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Shortswords.Projectiles;

namespace Shortswords.Items {
    public class XerocShortsword : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Xeroc Impaler");
            Tooltip.SetDefault("'Superheated plasma is great at stabbing things'");
        }

        public override void SetDefaults() {
            item.damage = 102;
            item.useStyle = 5;
            item.useAnimation = 18;
            item.useTime = 15;
            item.shootSpeed = 3f;
            item.knockBack = 6f;
            item.width = 38;
            item.height = 38;
            item.rare = 9;
            item.UseSound = SoundID.Item1;
            item.shoot = mod.ProjectileType<XerocProjectile>();
            item.value = 350000;
            item.noMelee = true;
            item.noUseGraphic = true;
            item.melee = true;
            item.autoReuse = true;
        }

        public override bool CanUseItem(Player player) {
            return player.ownedProjectileCounts[item.shoot] < 1;
        }

        public override void AddRecipes() {
            if (Shortswords.calamityMod == null) {
                return;
            }

            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(Shortswords.calamityMod.ItemType("MeldiateBar"), 10);
            recipe.AddIngredient(Shortswords.calamityMod.ItemType("GalacticaSingularity"), 2);
            recipe.AddIngredient(ItemID.LunarBar, 4);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
