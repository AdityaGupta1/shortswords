using Terraria.ID;
using Terraria.ModLoader;

namespace Shortswords.Items {
    public class NightShortsword : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Night Knife");
            Tooltip.SetDefault("'Knight knife? Night nife? Knight nife?'");
        }
        
        public override void SetDefaults() {
            item.melee = true;
            item.damage = 36;
            item.useStyle = 3;
            item.useAnimation = 18;
            item.useTime = 13;
            item.knockBack = 4f;
            item.width = 34;
            item.height = 36;
            item.scale = 1.25f;
            item.rare = 3;
            item.UseSound = SoundID.Item1;
            item.value = 40000;
            item.autoReuse = true;
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "DemoniteShortsword", 1);
            recipe.AddIngredient(null, "DungeonShortsword", 1);
            recipe.AddIngredient(null, "JungleShortsword", 1);
            recipe.AddIngredient(null, "HellstoneShortsword", 1);
            recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "CrimtaneShortsword", 1);
            recipe.AddIngredient(null, "DungeonShortsword", 1);
            recipe.AddIngredient(null, "JungleShortsword", 1);
            recipe.AddIngredient(null, "HellstoneShortsword", 1);
            recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
