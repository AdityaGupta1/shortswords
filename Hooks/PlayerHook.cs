using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Shortswords.Hooks
{
    class PlayerHook : ModPlayer
    {
        public override void OnHitNPC(Item item, NPC target, int damage, float knockback, bool crit)
        {
            if (!item.melee) {
                return;
            }

            int slot;
            bool daybreak = false;
            bool shadowfrost = false;

            for (slot = 3; slot < 8 + player.extraAccessorySlots; slot++) {
                if (player.armor[slot].type == mod.ItemType("SolarGauntlet")) {
                    daybreak = true;
                }

                if (player.armor[slot].type == mod.ItemType("ShadowfrostGauntlet")) {
                    shadowfrost = true;
                }
            }

            if (daybreak) {
                target.AddBuff(BuffID.Daybreak, 300);
            }

            if (shadowfrost) {
                target.AddBuff(BuffID.ShadowFlame, 300);
                target.AddBuff(BuffID.Frostburn, 300);
            }
        }

        public override void OnHitNPCWithProj(Projectile proj, NPC target, int damage, float knockback, bool crit)
        {
            OnHitNPC(null, target, damage, knockback, crit);
        }
    }
}