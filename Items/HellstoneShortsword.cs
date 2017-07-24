using Terraria.ID;
using Terraria.ModLoader;

namespace Shortswords.Items {
    public class HellstoneShortsword : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Burning Blade");
            Tooltip.SetDefault("'Try not to burn your hands'");
        }

        public override void SetDefaults() {
            item.melee = true;
            item.damage = 32;
            item.useStyle = 3;
            item.useAnimation = 18;
            item.useTime = 16;
            item.knockBack = 4f;
            item.width = 44;
            item.height = 44;
            item.scale = 1.5f;
            item.rare = 3;
            item.UseSound = SoundID.Item1;
            item.value = 18000;
            item.autoReuse = true;
            item.useTurn = true;
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HellstoneBar, 14);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
