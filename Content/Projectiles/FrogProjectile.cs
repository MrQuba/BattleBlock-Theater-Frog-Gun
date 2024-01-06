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
            Projectile.damage = 250;
            Projectile.knockBack = 6f;

            Projectile.tileCollide = true;
            Projectile.ignoreWater = true;
            Projectile.penetrate = 1;

            Projectile.friendly = true;
        }
    }
}