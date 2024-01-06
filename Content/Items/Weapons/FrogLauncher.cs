using FrogGun.Content.Items.Ammo;
using FrogGun.Content.Projectiles;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FrogGun.Content.Items.Weapons
{
	public class FrogLauncher : ModItem
	{
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.bbtFrogGun.hjson file.

		public override void SetDefaults()
        {
            Item.width = 40;
            Item.height = 40;
            Item.scale = 1.5f;

            Item.DamageType = DamageClass.Ranged;
            Item.damage = 250;
            Item.knockBack = 6f;

            Item.useTime = 25;
			Item.useAnimation = 25;
			Item.useStyle = ItemUseStyleID.Shoot;

			Item.value = Item.buyPrice(gold: 12, silver: 50);
            Item.rare = ItemRarityID.Lime;


			Item.autoReuse = true;
			Item.noMelee = true;

            Item.shoot = ModContent.ProjectileType<FrogProjectile>();
            Item.shootSpeed = 5f;

            Item.useAmmo = AmmoID.Rocket;
        }

    }
}