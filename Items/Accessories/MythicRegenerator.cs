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
            Item.width = 25;
            Item.height = 25;
            Item.maxStack = 1;
            Item.rare = 10;
			Item.expert = true;
			Item.accessory = true;
			Item.expertOnly = true;
			Item.value = Item.sellPrice(gold: 5);
        }
		
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			// Band of Regen is 1
			player.lifeRegen+= 7;
			player.statLifeMax2+= 100;
			player.potionDelayTime+= -900;
			// Reduces potion sickness to 45 seconds. Seems like I can't make it do 40 seconds.
        }
		
        public override void AddRecipes()
        {
			CreateRecipe(1)
				.AddIngredient(mod.GetItem("LifeRegenerator"), 1)
				.AddIngredient(ItemID.CharmofMyths, 1)
				.AddTile(TileID.TinkerersWorkbench)
				.Register();
        }
    }
}
// Thanks to absoluteAquarian#5189 on the TML Discord for giving me the potion delay code
// Thanks to Trivaxy#6867 for helping me fix the potion delay code