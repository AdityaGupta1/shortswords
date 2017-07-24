using Terraria.ID;
using Terraria.ModLoader;

namespace Shortswords.Items {
    public class MythicalShortsword : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Mythical Shortsword");
            Tooltip.SetDefault("'Wield the mythical ores from deep underground'");
        }

        public override void SetDefaults() {
            item.melee = true;
            item.damage = 50;
            item.useStyle = 3;
            item.useAnimation = 18;
            item.useTime = 9;
            item.knockBack = 4.5f;
            item.width = 48;
            item.height = 48;
            item.rare = 4;
            item.UseSound = SoundID.Item1;
            item.value = 200000;
            item.autoReuse = true;
            item.useTurn = true;
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("Shortswords:HardmodeOres1", 6);
            recipe.AddRecipeGroup("Shortswords:HardmodeOres2", 5);
            recipe.AddRecipeGroup("Shortswords:HardmodeOres3", 4);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
