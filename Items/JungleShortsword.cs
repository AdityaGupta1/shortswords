using Terraria.ID;
using Terraria.ModLoader;

namespace Shortswords.Items {
    public class JungleShortsword : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Spore Shank");
            Tooltip.SetDefault("'Why don't you try using a leaf?'");
        }
        
        public override void SetDefaults() {
            item.melee = true;
            item.damage = 25;
            item.useStyle = 3;
            item.useAnimation = 18;
            item.useTime = 14;
            item.knockBack = 4f;
            item.width = 36;
            item.height = 36;
            item.scale = 1.75f;
            item.rare = 3;
            item.UseSound = SoundID.Item1;
            item.value = 20000;
            item.autoReuse = true;
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.JungleSpores, 7);
            recipe.AddIngredient(ItemID.Stinger, 7);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
