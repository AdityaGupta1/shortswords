using Terraria.ID;
using Terraria.ModLoader;

namespace Shortswords.Items {
    public class DungeonShortsword : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Runic Shortsword");
            Tooltip.SetDefault("'A relic from the ancient Dungeon'");
        }
        
        public override void SetDefaults() {
            item.melee = true;
            item.damage = 17;
            item.useStyle = 3;
            item.useAnimation = 18;
            item.useTime = 10;
            item.knockBack = 4f;
            item.width = 38;
            item.height = 38;
            item.scale = 1.25f;
            item.rare = 2;
            item.UseSound = SoundID.Item1;
            item.value = 20000;
            item.autoReuse = true;
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Muramasa, 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
