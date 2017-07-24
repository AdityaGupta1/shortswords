using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Shortswords.Hooks {
    class ItemHook : GlobalItem {
        static int[] vanillaShortswords = new int[] { ItemID.CopperShortsword, ItemID.GoldShortsword, ItemID.IronShortsword, ItemID.LeadShortsword, ItemID.PlatinumShortsword, ItemID.SilverShortsword, ItemID.TinShortsword, ItemID.TungstenShortsword };

        public override void SetDefaults(Item item) {
            if (Array.IndexOf(vanillaShortswords, item.type) > -1) {
                item.damage += 1;
                item.autoReuse = true;
                item.useTurn = true;
            }
        }
    }
}