using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using System;

namespace Shortswords.Projectiles {
    public class XerocShootProjectile : ModProjectile {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Plasma Ball");
        }

        public override void SetDefaults() {
            projectile.width = 24;
            projectile.height = 24;
            projectile.aiStyle = -1;
            projectile.friendly = true;
            projectile.melee = true;
            projectile.light = 0.7f;
            projectile.tileCollide = false;
        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit) {
            target.AddBuff(BuffID.CursedInferno, 180);
        }

        private float rotationIncrease = 0f;
        private float maxIncrease = 0.8f;

        public override void AI() {
            if (rotationIncrease < maxIncrease) {
                rotationIncrease += 0.001f;
                projectile.rotation += rotationIncrease;
            } else {
                projectile.Kill();
            }
        }
    }
}
