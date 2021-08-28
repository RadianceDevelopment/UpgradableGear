using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Weapons
{
	public class SoulBow_T2 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Soul Bow II");
			Tooltip.SetDefault("The bow begans to shudder slightly...");
	    }

		public override void SetDefaults() 
		{
			Item.damage = 10;
			Item.knockBack = 4;
			Item.DamageType = DamageClass.Ranged;
			Item.UseSound = SoundID.Item5;
			Item.useAmmo = AmmoID.Arrow;
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.useAnimation = 20;
			Item.autoReuse = false;
			Item.noMelee = true;
			Item.shoot = 1;
			Item.shootSpeed = 6.5f;
			Item.width = 18;
			Item.height = 44;
			Item.useTime = 24;
			Item.useAnimation = 20;
            Item.rare = ItemRarityID.Blue;
			Item.value = Item.sellPrice(copper: 0);
		}

		public override void AddRecipes()
		{
			CreateRecipe(1)
				.AddIngredient<SoulBow_T1>(1)
				.AddIngredient<MobSoul>(5)
				.AddTile(TileID.WorkBenches)
				.Register();
		}
	}
}