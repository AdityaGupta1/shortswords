using Terraria.ID;
using Terraria.ModLoader;

namespace Shortswords.Items {
    public class MeteorShortsword : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Space Knife");
            Tooltip.SetDefault("'A knife. From space.'");
        }
        
        public override void SetDefaults() {
            item.melee = true;
            item.damage = 26;
            item.useStyle = 3;
            item.useAnimation = 18;
            item.useTime = 16;
            item.knockBack = 4f;
            item.width = 34;
            item.height = 34;
            item.scale = 1.25f;
            item.rare = 1;
            item.UseSound = SoundID.Item1;
            item.value = 17500;
            item.autoReuse = true;
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.MeteoriteBar, 9);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
