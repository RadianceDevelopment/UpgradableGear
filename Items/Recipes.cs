using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items
{
    public class Recipes : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Recipes");
			Tooltip.SetDefault("This does nothing.\nJust adds code for recipes since idk how to do that without making an item");
		}

		public override void SetDefaults() 
		{
			item.width = 40;
			item.height = 40;
			item.rare = 0;
			item.maxStack = 1;
			item.value = Item.sellPrice(0, 0, 0, 0);
		}
		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 5);
			recipe.AddIngredient(ItemID.Gel, 7);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.SlimeStaff, 1);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 20);
			recipe.AddIngredient(ItemID.CursedFlame, 5);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.Ichor, 2);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 20);
			recipe.AddIngredient(ItemID.Ichor, 5);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.CursedFlame, 2);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 10);
			recipe.AddIngredient(ItemID.DepthMeter, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.WeatherRadio, 1);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 10);
			recipe.AddIngredient(ItemID.Compass, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.Sextant, 1);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 15);
			recipe.AddTile(TileID.WorkBenches);
			// Fisherman's Pocket Guide
			recipe.SetResult(3120, 1);
			recipe.AddRecipe();
			
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LightShard, 1);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.DarkShard, 1);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DarkShard, 1);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.LightShard, 1);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 1);
			recipe.AddIngredient(ItemID.SoulofLight, 1);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.SoulofNight, 1);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 1);
			recipe.AddIngredient(ItemID.SoulofNight, 1);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.SoulofLight, 1);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HealingPotion, 4);
			recipe.AddIngredient(ItemID.PixieDust, 4);
			recipe.AddTile(TileID.Bottles);
			recipe.SetResult(ItemID.GreaterHealingPotion, 4);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BottledWater);
			recipe.AddIngredient(ItemID.Deathweed);
			recipe.AddIngredient(ItemID.Vertebrae);
			recipe.AddIngredient(ItemID.Cactus, 3);
			recipe.AddIngredient(ItemID.Stinger, 2);
			recipe.AddTile(TileID.Bottles);
			recipe.SetResult(ItemID.ThornsPotion);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 10);
			recipe.AddIngredient(ItemID.Feather, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.GiantHarpyFeather);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ClothierVoodooDoll);
			recipe.AddIngredient(ItemID.HellstoneBar, 5);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(ItemID.GuideVoodooDoll);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(1001, 1);
			recipe.AddIngredient(ItemID.TurtleShell, 1);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.TurtleHelmet, 1);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(1002, 1);
			recipe.AddIngredient(ItemID.TurtleShell, 1);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.TurtleHelmet, 1);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(1003, 1);
			recipe.AddIngredient(ItemID.TurtleShell, 1);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.TurtleHelmet, 1);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(1004, 1);
			recipe.AddIngredient(ItemID.TurtleShell, 1);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.TurtleScaleMail, 1);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(1005, 1);
			recipe.AddIngredient(ItemID.TurtleShell, 1);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.TurtleLeggings, 1);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldenKey, 3);
			recipe.AddIngredient(ItemID.ShadowScale, 5);
			recipe.AddIngredient(ItemID.HellstoneBar, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.ShadowKey, 1);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldenKey, 3);
			recipe.AddIngredient(ItemID.TissueSample, 7);
			recipe.AddIngredient(ItemID.HellstoneBar, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.ShadowKey, 1);
			recipe.AddRecipe();
		}
	}
}