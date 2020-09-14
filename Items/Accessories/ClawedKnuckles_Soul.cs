using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class ClawedKnuckles_Soul : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Soulified Clawed Knuckles");
			Tooltip.SetDefault("+5 Defense\n+16% Melee Speed\nA set of claws that have fleshy knuckles embedded into them\nInfused with many souls to amplify its power\nStrange whispers seem to emanate from it....");
		}
		
        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 30;
            item.maxStack = 1;
            item.value = Item.sellPrice(0, 6, 50, 55);
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
			recipe.AddIngredient(mod.GetItem("MobSoul"), 55);
			//recipe.AddTile(TileType<SoulForge>());
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("ClawedKnuckles"));
			recipe.AddIngredient(mod.GetItem("MobSoul"), 55);
			//recipe.AddTile(TileType<SoulForge>());
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}