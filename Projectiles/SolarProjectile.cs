using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Shortswords;

namespace Shortswords.Projectiles
{
	public class SolarProjectile : ModProjectile
	{
		bool hasCreatedShoot = false;

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Solar Stabber");
		}

		public override void SetDefaults()
		{
			projectile.width = 24;
			projectile.height = 24;
			projectile.aiStyle = 19;
			projectile.friendly = true;
			projectile.penetrate = -1;
			projectile.tileCollide = false;
			projectile.scale = 1.3f;
			projectile.hide = true;
			projectile.ownerHitCheck = true;
			projectile.melee = true;
			projectile.alpha = 0;
		}

		public float movementFactor
		{
			get { return projectile.ai[0]; }
			set { projectile.ai[0] = value; }
		}

		public override void AI()
		{
			Player projOwner = Main.player[projectile.owner];
			Vector2 ownerMountedCenter = projOwner.RotatedRelativePoint(projOwner.MountedCenter, true);
			projectile.direction = projOwner.direction;
			projOwner.heldProj = projectile.whoAmI;
			projOwner.itemTime = projOwner.itemAnimation;
			projectile.position.X = ownerMountedCenter.X - (float)(projectile.width / 2);
			projectile.position.Y = ownerMountedCenter.Y - (float)(projectile.height / 2);
			if (!projOwner.frozen)
			{
				if (movementFactor == 0f)
				{
					movementFactor = 3f;
					projectile.netUpdate = true;
				}
				if (projOwner.itemAnimation < projOwner.itemAnimationMax / 3)
				{
					movementFactor -= 2.4f;
				}
				else
				{
					movementFactor += 2.1f;
				}
			}
			projectile.position += projectile.velocity * movementFactor;
			if (projOwner.itemAnimation == 0)
			{
				projectile.Kill();
			}
			projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + MathHelper.ToRadians(135f);
			if (projectile.spriteDirection == -1)
			{
				projectile.rotation -= MathHelper.ToRadians(90f);
			}

			if (!hasCreatedShoot) {
				if (Shortswords.random.Next(4) == 0) {
					double x = projectile.velocity.X;
					double y = projectile.velocity.Y;

					double spread = 5d;
					spread *= Math.PI / 180;
					double angle = Math.Atan2(y, x) + (spread * (Shortswords.random.NextDouble() - 0.5));
					double velocity = 5 * Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));

					x = velocity * Math.Cos(angle);
					y = velocity * Math.Sin(angle);

					Projectile.NewProjectile(projectile.position.X + (projectile.width / 2), projectile.position.Y + (projectile.height / 2), (float) x, (float) y, mod.ProjectileType<SolarRocketProjectile>(), 200, 8f, projectile.owner);
				}
				Projectile.NewProjectile(projectile.position.X + (projectile.width / 2), projectile.position.Y + (projectile.height / 2), projectile.velocity.X * 3, projectile.velocity.Y * 3, mod.ProjectileType<SolarShootProjectile>(), 130, 6f, projectile.owner);
				hasCreatedShoot = true;
			}
		}
	}
}
