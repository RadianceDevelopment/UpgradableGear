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
				.AddIngredient(mod.GetItem("MobSoul"), 5)
				.AddIngredient(ItemID.Gel, 7)
				.AddTile(TileID.WorkBenches)
				.resultItem(ItemID.SlimeStaff, 1)
				.Register();
		}
	}
}
*/