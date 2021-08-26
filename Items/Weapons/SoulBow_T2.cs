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
			Tooltip.SetDefault("A bow infused with more souls");
	    }

		public override void SetDefaults() 
		{
			Item.damage = 10;
			Item.knockBack = 3.5f;
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
			Item.rare = 0;
			Item.value = Item.sellPrice(copper: 0);
		}

		public override void AddRecipes()
		{
			CreateRecipe(1)
				.AddIngredient(mod.GetItem("SoulBow_T1"))
				.AddIngredient(mod.GetItem("MobSoul"), 5)
				.AddTile(TileID.WorkBenches)
				.Register();
		}
	}
}