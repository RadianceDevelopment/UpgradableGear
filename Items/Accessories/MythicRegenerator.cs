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
			Tooltip.SetDefault("An ancient, legendary item made from 3 relics of the past\nImproves life regeneration and maximum health\nReduces Potion Sickness to 45 seconds\nMight be cursed?");
		}
		
        public override void SetDefaults()
        {
            item.width = 25;
            item.height = 25;
            item.maxStack = 1;
            item.value = Item.sellPrice(1, 25, 0, 0);
            item.rare = 10;
			item.accessory = true;
			item.expert = true;
			item.expertOnly = true;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			// Band of Regen is 1
			player.lifeRegen+= 7;
			player.statLifeMax2+= 100;
			// Reduces potion sickness to 45 seconds. Seems like I can't make it do 40 seconds.
			player.potionDelayTime+= -900;
        }
        public override void AddRecipes()
        {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("LifeRegenerator"), 1);
			recipe.AddIngredient(ItemID.CharmofMyths, 1);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}
// Thanks to absoluteAquarian#5189 on the TML Discord for giving me the potion delay code
// Thanks to Trivaxy#6867 for helping me fix the potion delay code