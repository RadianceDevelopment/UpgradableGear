using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Weapons
{
	public class SoulBow_T1 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Soul Bow I");
			Tooltip.SetDefault("A bow crafted from the souls of fallen foes");
	    }

		public override void SetDefaults() 
		{
			Item.damage = 8;
			Item.knockBack = 3;
			Item.DamageType = DamageClass.Ranged;
			Item.UseSound = SoundID.Item5;
			Item.useAmmo = AmmoID.Arrow;
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.useAnimation = 20;
			Item.autoReuse = false;
			Item.noMelee = true;
			Item.shoot = 1;
			Item.shootSpeed = 6.3f;
			Item.width = 18;
			Item.height = 44;
			Item.useTime = 26;
			Item.rare = 0;
			Item.value = Item.sellPrice(copper: 0);
		}

		public override void AddRecipes()
		{
			CreateRecipe(1)
				.AddIngredient<MobSoul>(10)
				.AddTile(TileID.WorkBenches)
				.Register();
		}
	}
}