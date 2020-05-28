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
			Tooltip.SetDefault("The bow begans to shutter slightly");
	    }

		public override void SetDefaults() 
		{
			item.damage = 11;
			item.knockBack = 3.7f;
			item.ranged = true;
			item.UseSound = SoundID.Item5;
			item.useAmmo = AmmoID.Arrow;
			item.autoReuse = false;
			item.noMelee = true;
			item.shootSpeed = 6.5f;
			item.width = 40;
			item.height = 40;
			item.useTime = 23;
			item.useAnimation = 20;
			item.useStyle = 5;
			item.rare = 1;
			item.value = Item.sellPrice(0, 0, 0, 37);
			
		}

		public override void AddRecipes()
		{
			
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("SoulBow_T2"));
			recipe.AddIngredient(mod.GetItem("MobSoul"), 6);
			//recipe.AddTile(TileType<SoulInfuser>());
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}