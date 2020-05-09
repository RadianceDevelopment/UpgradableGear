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
		/*
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
		*/
		/*
		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			//recipe.AddRecipeGroup("UpgradableGear:PreHMWorkbench");
			recipe.AddIngredient(ItemID.WorkBench, 1);
			//recipe.AddRecipeGroup("UpgradableGear:IronAnvil");
			recipe.AddIngredient(ItemID.IronAnvil, 1);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.WorkBench, 1);
			//recipe.AddRecipeGroup("UpgradableGear:IronAnvil");
			recipe.AddIngredient(ItemID.LeadAnvil, 1);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		*/
	}
}

// ItemType("ItemName") for modded items