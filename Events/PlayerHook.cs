using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Shortswords.Events
{
    class PlayerHook : ModPlayer
    {
        public override void OnHitNPC(Item item, NPC target, int damage, float knockback, bool crit)
        {
            int slot;
            bool flag = false;
            for (slot = 3; slot < 8 + player.extraAccessorySlots; slot++)
            {
                if (player.armor[slot].type == mod.ItemType("SolarGauntlet"))
                {
                    flag = true;
                    break;
                }
            }
            if (flag)
            {
                target.AddBuff(BuffID.Daybreak, 300);
            }
        }
        
        public override void OnHitNPCWithProj(Projectile proj, NPC target, int damage, float knockback, bool crit)
        {
            OnHitNPC(null, target, damage, knockback, crit);
        }
    }
}