using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Shortswords.Items {
    public class SolarGauntlet : ModItem {
        public override void SetStaticDefaults() {
            Tooltip.SetDefault("16% increased melee damage and speed" +
            "\nInflicts Daybroken on melee attacks");
        }

        public override void SetDefaults() {
            item.width = 26;
            item.height = 30;
            item.value = 500000;
            item.rare = 10;
            item.accessory = true;
            item.defense = 2;
        }

        public override void UpdateAccessory(Player player, bool hideVisual) {
            player.meleeDamage *= 1.16f;
            player.meleeSpeed *= 1.16f;
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "ShadowfrostGauntlet", 1);
            recipe.AddIngredient(ItemID.FragmentSolar, 8);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}