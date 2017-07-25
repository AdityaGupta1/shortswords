using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Shortswords.Projectiles {
    public class XerocProjectile : ModProjectile {
        bool hasCreatedShoot = false;

        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Xeroc Impaler");
        }

        public override void SetDefaults() {
            projectile.width = 38;
            projectile.height = 38;
            projectile.scale = 1.4f;
            projectile.aiStyle = 19;
            projectile.friendly = true;
            projectile.penetrate = -1;
            projectile.tileCollide = false;
            projectile.hide = true;
            projectile.ownerHitCheck = true;
            projectile.melee = true;
            projectile.alpha = 0;
        }

        public float movementFactor {
            get { return projectile.ai[0]; }
            set { projectile.ai[0] = value; }
        }

        public override void AI() {
            Player projOwner = Main.player[projectile.owner];
            Vector2 ownerMountedCenter = projOwner.RotatedRelativePoint(projOwner.MountedCenter, true);
            projectile.direction = projOwner.direction;
            projOwner.heldProj = projectile.whoAmI;
            projOwner.itemTime = projOwner.itemAnimation;
            projectile.position.X = ownerMountedCenter.X - (float)(projectile.width / 2);
            projectile.position.Y = ownerMountedCenter.Y - (float)(projectile.height / 2);
            if (!projOwner.frozen) {
                if (movementFactor == 0f) {
                    movementFactor = 3f;
                    projectile.netUpdate = true;
                }
                if (projOwner.itemAnimation < projOwner.itemAnimationMax / 3) {
                    movementFactor -= 2.4f;
                } else {
                    movementFactor += 2.1f;
                }
            }
            projectile.position += projectile.velocity * movementFactor;
            if (projOwner.itemAnimation == 0) {
                projectile.Kill();
            }
            projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + MathHelper.ToRadians(135f);
            if (projectile.spriteDirection == -1) {
                projectile.rotation -= MathHelper.ToRadians(90f);
            }

            if (!hasCreatedShoot) {
                float velocityMultiplier = 1.2f;
                int damage = 90;
                Projectile.NewProjectile(projectile.position.X + (projectile.width / 2), projectile.position.Y + (projectile.height / 2), projectile.velocity.X * velocityMultiplier, projectile.velocity.Y * velocityMultiplier, mod.ProjectileType<XerocShootProjectile>(), damage * 3, 6f, projectile.owner);
                Projectile.NewProjectile(projectile.position.X + (projectile.width / 2), projectile.position.Y + (projectile.height / 2), projectile.velocity.X * velocityMultiplier * 2, projectile.velocity.Y * velocityMultiplier * 2, mod.ProjectileType<XerocShootProjectile>(), damage * 2, 6f, projectile.owner);
                Projectile.NewProjectile(projectile.position.X + (projectile.width / 2), projectile.position.Y + (projectile.height / 2), projectile.velocity.X * velocityMultiplier * 3, projectile.velocity.Y * velocityMultiplier * 3, mod.ProjectileType<XerocShootProjectile>(), damage, 6f, projectile.owner);
                hasCreatedShoot = true;
            }
        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit) {
            target.AddBuff(BuffID.CursedInferno, 180);
        }
    }
}
