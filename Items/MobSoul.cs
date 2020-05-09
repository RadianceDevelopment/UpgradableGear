using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items
{
	public class MobSoul : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Monster Soul");
			Tooltip.SetDefault("The concentrated essence of monsters");
		}

		public override void SetDefaults() 
		{
			item.width = 40;
			item.height = 40;
			item.value = 0;
			item.rare = 0;
			item.maxStack = 999;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Gel, 1);
			recipe.AddTile(TileID.WorkBenches);
			//recipe.AddTile(TileType<SoulInfuser>());
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.RottenChunk, 1);
			recipe.AddTile(TileID.WorkBenches);
			//recipe.AddTile(TileType<SoulInfuser>());
			recipe.SetResult(this, 3);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Vertebrae, 1);
			recipe.AddTile(TileID.WorkBenches);
			//recipe.AddTile(TileType<SoulInfuser>());
			recipe.SetResult(this, 3);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Bone, 1);
			recipe.AddTile(TileID.WorkBenches);
			//recipe.AddTile(TileType<SoulInfuser>());
			recipe.SetResult(this, 5);
			recipe.AddRecipe();
		}
	}
}