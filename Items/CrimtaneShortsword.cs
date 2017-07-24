using Terraria.ID;
using Terraria.ModLoader;

namespace Shortswords.Items {
    public class CrimtaneShortsword : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Sanguinary Shortsword");
            Tooltip.SetDefault("'Watch your enemies bleed'");
        }
        
        public override void SetDefaults() {
            item.melee = true;
            item.damage = 19;
            item.useStyle = 3;
            item.useAnimation = 18;
            item.useTime = 11;
            item.knockBack = 4f;
            item.width = 32;
            item.height = 42;
            item.rare = 1;
            item.UseSound = SoundID.Item1;
            item.value = 10000;
            item.autoReuse = true;
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.CrimtaneBar, 7);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
