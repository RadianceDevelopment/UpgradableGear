using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using SoulSang.Global;

namespace SoulSang.Global
{
	public class Recipes : ModSystem
	{

		public override void AddRecipes()
		{
			// Upgrade Greater Healing Potions
			Recipe recipe = Recipe.Create(ItemID.GreaterHealingPotion);
			recipe.AddIngredient(ItemID.HealingPotion);
			recipe.AddIngredient(ItemID.PixieDust);
			recipe.AddIngredient(ItemID.CrystalShard);
			recipe.AddTile(TileID.Bottles);
			recipe.Register();
		}
	}
}



/*
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang
{
	public static class SoulSangRecipes
	{
		
		public static void Load(Mod mod) {
			AddRecipes(mod);
		}

		private static void AddRecipes(Mod mod) {
			
			var resultItem = ModContent.GetInstance<Items.SlimeStaff>()
				.AddIngredient(mod.GetItem("StraySoul"), 5)
				.AddIngredient(ItemID.Gel, 7)
				.AddTile(TileID.WorkBenches)
				.resultItem(ItemID.SlimeStaff, 1)
				.Register();
		}
	}
}
*/