using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Weapons
{
	public class SoulBow_T3 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Soul Bow III");
			Tooltip.SetDefault("The bow begans to shudder slightly");
	    }

		public override void SetDefaults() 
		{
			Item.damage = 12;
			Item.knockBack = 3.7f;
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
			Item.useTime = 22;
			Item.useAnimation = 20;
			Item.rare = 1;
			Item.value = Item.sellPrice(copper: 0);
		}

		public override void AddRecipes()
		{
			CreateRecipe(1)
				.AddIngredient(mod.GetItem("SoulBow_T2"))
				.AddIngredient(mod.GetItem("MobSoul"), 10)
				.AddTile(TileID.Anvils)
				.Register();
		}
	}
}