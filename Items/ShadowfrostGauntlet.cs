using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Shortswords.Items {
    public class ShadowfrostGauntlet : ModItem {
        public override void SetStaticDefaults() {
            Tooltip.SetDefault("12% increased melee damage and speed" +
            "\nInflicts Shadowflame and Frostburn on any attack");
        }

        public override void SetDefaults() {
            item.width = 26;
            item.height = 30;
            item.value = 200000;
            item.rare = 7;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual) {
            player.meleeDamage *= 1.12f;
            player.meleeSpeed *= 1.12f;
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.FireGauntlet, 1);
            recipe.AddIngredient(ItemID.ShadowFlameKnife, 1);
            recipe.AddIngredient(ItemID.FrostCore, 1);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}