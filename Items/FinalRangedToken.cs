using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items
{
	public class FinalRangedToken : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Final Ranged Token");
			Tooltip.SetDefault("Placeholder item used to craft the True Combatant's Essence");
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
			    .AddIngredient(ItemID.SDMG, 1)
				.AddTile(TileID.LunarCraftingStation)
				.Register();
			
			// Celebration
			resultItem.CreateRecipe()
				.AddIngredient(3546, 1)
				.AddTile(TileID.LunarCraftingStation)
				.Register();
		}
	}
}