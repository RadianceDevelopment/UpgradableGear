using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class ClawedKnuckles_Soul : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Soul-Infused Clawed Knuckles");
			Tooltip.SetDefault("+5 Defense\nA set of claws that have fleshy knuckles embedded into them\nHas been infused with many souls to amplify its power\nIncreases melee speed by 16%");
		}
		
        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 30;
            item.maxStack = 1;
            item.value = Item.sellPrice(0, 6, 50, 75);
            item.rare = 5;
			item.accessory = true;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.statDefense+= 5;
			player.meleeSpeed+= 0.16f;
        }
        public override void AddRecipes()
        {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FleshKnuckles);
			recipe.AddIngredient(ItemID.FeralClaws);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 75);
			//recipe.AddTile(TileType<SoulForge>());
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("ClawedKnuckles"));
			recipe.AddIngredient(mod.GetItem("MobSoul"), 75);
			//recipe.AddTile(TileType<SoulForge>());
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}