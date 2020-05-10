using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class MythicRegenerator : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Mythic Regenerator");
			Tooltip.SetDefault("An ancient, legendary item made from 3 relics of the past\nImproves life regeneration and maximum health\nReduces Potion Sickness to 40 seconds");
		}
		
        public override void SetDefaults()
        {
            item.width = 25;
            item.height = 25;
            item.maxStack = 1;
            item.value = Item.sellPrice(1, 20, 0, 0);
            item.rare = 10;
			item.accessory = true;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			// Band of Regen is 1
			player.lifeRegen+= 6;
			player.statLifeMax2+= 100;
			player.potionDelay = 40;
        }
        public override void AddRecipes()
        {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("LifeRegenerator"), 1);
			recipe.AddIngredient(ItemID.CharmofMyths, 1); 
			// Make it use both of these
			//recipe.AddTile(TileID.LunarCraftingTable);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}
// Thanks to absoluteAquarian#5189 on the TML Discord for giving me the potion delay code