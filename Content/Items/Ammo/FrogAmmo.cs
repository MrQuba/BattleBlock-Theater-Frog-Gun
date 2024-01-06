using FrogGun.Content.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FrogGun.Content.Items.Ammo
{
	public class FrogAmmo : ModItem
	{
		public override void SetDefaults()
        {
            Item.width = 8;
            Item.height = 8;

            Item.DamageType = DamageClass.Ranged;
			Item.damage = 250;
			Item.knockBack = 2.5f;

			Item.maxStack = 9999;
			Item.consumable = true;

            Item.shoot = ModContent.ProjectileType<FrogProjectile>();
			Item.shootSpeed = 15f;
            Item.ammo = AmmoID.Rocket;
            //Item.ammo = AmmoID.Rocket;
		}

		public override void AddRecipes()
		{
			// TO DO - Craft Multiple Bullets
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.Frog, 1);
            recipe.AddIngredient(ItemID.TopHat, 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();
		}
	}
}