using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items
{
	public class FinalMeleeToken : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Final Melee Token");
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
				.AddIngredient(ItemID.Meowmere, 1)
				.AddTile(TileID.LunarCraftingStation)
				.Register();
			
			CreateRecipe(1)
				.AddIngredient(ItemID.StarWrath, 1)
				.AddTile(TileID.LunarCraftingStation)
				.Register();
			
			CreateRecipe(1)
				.AddIngredient(ItemID.Terrarian, 1)
				.AddTile(TileID.LunarCraftingStation)
				.Register();
		}
	}
}

// Sprite by @masterfulpotato#4037 on the Discord