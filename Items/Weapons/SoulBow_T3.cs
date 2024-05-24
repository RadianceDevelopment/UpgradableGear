using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Weapons
{
	public class SoulBow_T3 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("Soul Bow III");
			// Tooltip.SetDefault("With a fierce twang, the bow recoils against you...");
	    }

		public override void SetDefaults() 
		{
			Item.damage = 15;
			Item.knockBack = 4;
			Item.DamageType = DamageClass.Ranged;
			Item.UseSound = SoundID.Item5;
			Item.useAmmo = AmmoID.Arrow;
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.useAnimation = 20;
			Item.autoReuse = false;
			Item.noMelee = true;
			Item.shoot = 1;
			Item.shootSpeed = 7;
			Item.width = 20;
			Item.height = 46;
			Item.useTime = 20;
			Item.useAnimation = 20;
            Item.rare = ItemRarityID.Green;
			Item.value = Item.sellPrice(silver: 30);
		}

		public override void AddRecipes()
		{
			CreateRecipe(1)
				.AddIngredient<SoulBow_T2>(1)
				.AddIngredient<StraySoul>(10)
				.AddIngredient(ItemID.Diamond, 1)
				.AddTile(TileID.Anvils)
				.Register();
		}
	}
}