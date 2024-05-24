/*
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Microsoft.Xna.Framework;
using static Terraria.ModLoader.ModContent;

namespace SoulSang.Tiles
{
	public class SoulInfuser : ModTile
	{
		public override void SetDefaults() {
			Main.tileSolidTop[Type] = true;
			Main.tileFrameImportant[Type] = true;
			Main.tileNoAttach[Type] = true;
			Main.tileTable[Type] = true;
			Main.tileLavaDeath[Type] = true;
			TileObjectData.newTile.CopyFrom(TileObjectData.Style2x1);
			TileObjectData.newTile.CoordinateHeights = new[] { 18 };
			TileObjectData.addTile(Type);
			//AddToArray(ref TileID.Sets.RoomNeeds.CountsAsTable);
			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Soul Infuser");
			AddMapEntry(new Color(200, 200, 200), name);
			disableSmartCursor = true;
			//adjTiles = new int[] { TileID.WorkBenches };
		}

		public override void NumDust(int i, int j, bool fail, ref int num) {
			num = fail ? 1 : 3;
		}

		public override void KillMultiTile(int i, int j, int frameX, int frameY) {
			Item.NewItem(i * 16, j * 16, 32, 16, ItemType<Items.Placeable.SoulInfuser>());
		}
	}
}
*/

/*
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace SoulSang.Tiles
{
	public class SoulInfuser : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Soul Infuser");
			Tooltip.SetDefault("Still WIP!");
		}

		public override void SetDefaults() 
		{
			item.width = 40;
			item.height = 40;
			item.value = 0;
			item.rare = 0;
			item.maxStack = 99;
		}
		
		public override void AddRecipeGroups()
		{
			RecipeGroup group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Pre-Hardmode Workbench", new int[]
			{
				ItemID.811,
				ItemID.673,
				ItemID.812,
				ItemID.2229,
			    ItemID.635,
				ItemID.3158,
				ItemID.3157,
				ItemID.3156,
				ItemID.814,
				ItemID.2534,
				ItemID.1795,
				ItemID.636,
				ItemID.916,
				ItemID.815,
				ItemID.1817,
				ItemID.36,
				ItemID.2632,
				ItemID.2251,
				ItemID.2252,
				ItemID.2633,
				ItemID.2631,
				
				ItemID.1511,
				ItemID.1398,
				ItemID.1401,
				ItemID.1404,
				ItemID.1461
			});
			RecipeGroup.RegisterGroup("UpgradableGear:PreHMWorkbench", group);
		}
		
        
		public override void AddRecipeGroups()
		{
			RecipeGroup group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Iron Anvil", new int[]
			{
				ItemID.IronAnvil,
				ItemID.LeadAnvil
			});
			RecipeGroup.RegisterGroup("UpgradableGear:IronAnvil", group);
		}
		
		
		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			//recipe.AddRecipeGroup("UpgradableGear:PreHMWorkbench");
			recipe.AddIngredient(ItemID.WorkBench, 1);
			//recipe.AddRecipeGroup("UpgradableGear:IronAnvil");
			recipe.AddIngredient(ItemID.IronAnvil, 1);
			recipe.AddIngredient(mod.GetItem("StraySoul"), 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.WorkBench, 1);
			//recipe.AddRecipeGroup("UpgradableGear:IronAnvil");
			recipe.AddIngredient(ItemID.LeadAnvil, 1);
			recipe.AddIngredient(mod.GetItem("StraySoul"), 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		
	}
}
*/
// ItemType("ItemName") for modded items