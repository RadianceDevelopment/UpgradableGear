using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items
{
	public class FinalSummonerToken : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Final Summoner Token");
			Tooltip.SetDefault("Placeholder Item used to craft the Soul Sage's Essence");
		}

		public override void SetDefaults() 
		{
			Item.width = 20;
			Item.height = 20;
			Item.rare = 11;
			Item.maxStack = 999;
			Item.value = Item.buyPrice(copper: 0);
		}

		public override void AddRecipes() 
		{
			CreateRecipe(1)
				.AddIngredient(ItemID.RainbowCrystalStaff, 1)
				.AddTile(TileID.LunarCraftingStation)
				.Register();
			
			// Lunar Portal Staff
			CreateRecipe(1)
				.AddIngredient(3569, 1)
				.AddTile(TileID.LunarCraftingStation)
				.Register();
		}
	}
}