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
			item.damage = 8;
			item.knockBack = 3;
			item.ranged = true;
			item.UseSound = SoundID.Item5;
			item.useAmmo = AmmoID.Arrow;
			item.autoReuse = false;
			item.noMelee = true;
			item.shoot = 1;
			item.shootSpeed = 6.3f;
			item.width = 18;
			item.height = 44;
			item.useTime = 26;
			item.useAnimation = 20;
			item.useStyle = 5;
			item.rare = 0;
			item.value = Item.sellPrice(0, 0, 0, 7);
			
		}

		public override void AddRecipes()
		{
			
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}