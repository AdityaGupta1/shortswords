using Terraria.ID;
using Terraria.ModLoader;

namespace Shortswords.Items {
    public class HallowedShortsword : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Excali-stab-bur");
            Tooltip.SetDefault("'Try pulling it out of a rock'");
        }

        public override void SetDefaults() {
            item.melee = true;
            item.damage = 55;
            item.useStyle = 3;
            item.useAnimation = 18;
            item.useTime = 8;
            item.knockBack = 4.5f;
            item.width = 44;
            item.height = 44;
            item.rare = 5;
            item.UseSound = SoundID.Item1;
            item.value = 400000;
            item.autoReuse = true;
            item.useTurn = true;
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HallowedBar, 7);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
