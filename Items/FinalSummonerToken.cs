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
			Tooltip.SetDefault("Placeholder item used to craft the True Combatant's Essence");
		}

		public override void SetDefaults() 
		{
			item.width = 40;
			item.height = 40;
			item.value = 0;
			item.rare = 11;
			item.maxStack = 999;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.RainbowCrystalStaff, 1);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			// Lunar Portal Staff
			recipe.AddIngredient(3569, 1);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}