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
			item.damage = 9;
			item.knockBack = 3.5f;
			item.ranged = true;
			item.UseSound = SoundID.Item5;
			item.useAmmo = AmmoID.Arrow;
			item.autoReuse = false;
			item.noMelee = true;
			item.shoot = 1;
			item.shootSpeed = 6.5f;
			item.width = 18;
			item.height = 44;
			item.useTime = 25;
			item.useAnimation = 20;
			item.useStyle = 5;
			item.rare = 0;
			item.value = Item.sellPrice(0, 0, 0, 15);
			
		}

		public override void AddRecipes()
		{
			
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("SoulBow_T1"));
			recipe.AddIngredient(mod.GetItem("MobSoul"), 4);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}