using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class ClawedKnuckles : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Clawed Knuckles");
			Tooltip.SetDefault("+4 Defense\nIncreases melee speed by 12%\nA set of claws that have fleshy knuckles embedded into them\nCombining the two seems to prevent the rancid smell of flesh from attracting creatures");
		}
		
        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 30;
            item.maxStack = 1;
            item.value = Item.sellPrice(0, 6, 50, 0);
            item.rare = 5;
			item.accessory = true;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.statDefense+= 4;
			player.meleeSpeed+= 0.12f;
        }
        public override void AddRecipes()
        {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FleshKnuckles);
			recipe.AddIngredient(ItemID.FeralClaws);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}