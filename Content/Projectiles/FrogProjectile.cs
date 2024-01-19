using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace FrogGun.Content.Projectiles
{
	internal class FrogProjectile : ModProjectile
	{
        public override void SetDefaults()
        {
            Projectile.width = 48;
            Projectile.height = 48;

            Projectile.DamageType = DamageClass.Ranged;
            Projectile.damage = 320;
            Projectile.knockBack = 6f;

            Projectile.tileCollide = false;
            Projectile.ignoreWater = true;
            Projectile.penetrate = 8;
            Projectile.timeLeft = 120;

            Projectile.friendly = true;
        }
    }
}