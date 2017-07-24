using Terraria.ID;
using Terraria.ModLoader;

namespace Shortswords.Items {
    public class DemoniteShortsword : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Demon Dagger");
            Tooltip.SetDefault("'Made of a strange metal from the corrupted lands'");
        }

        public override void SetDefaults() {
            item.melee = true;
            item.damage = 15;
            item.useStyle = 3;
            item.useAnimation = 18;
            item.useTime = 10;
            item.knockBack = 4f;
            item.width = 30;
            item.height = 30;
            item.rare = 1;
            item.UseSound = SoundID.Item1;
            item.value = 10000;
            item.autoReuse = true;
            item.useTurn = true;
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DemoniteBar, 7);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
