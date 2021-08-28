using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class MythicRegenerator : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Mythical Soul Regenerator");
			Tooltip.SetDefault("An ancient, legendary item made from long forgotten relics\nImproves life regeneration and maximum health\nReduces Potion Sickness to 30 seconds\nMight be cursed?");
		}
		
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 1;
			Item.accessory = true;
			Item.expertOnly = true;
            Item.rare = ItemRarityID.Purple;
			Item.value = Item.sellPrice(gold: 30);
        }
		
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			// Band of Regen is 1
			player.lifeRegen += 8;
			player.statLifeMax2 += 150;
			player.potionDelayTime -= 1800;
			// Reduces potion sickness to 30 seconds.
        }
		
        public override void AddRecipes()
        {
			CreateRecipe(1)
				.AddIngredient<SoulRegenerator>(1)
				.AddIngredient(ItemID.CharmofMyths, 1)
				.AddIngredient(ItemID.LunarBar, 3)
				.AddTile(TileID.LunarCraftingStation)
				.Register();
        }
    }
}
// Thanks to absoluteAquarian#5189 on the TML Discord for giving me the potion delay code
// Thanks to Trivaxy#6867 for helping me fix the potion delay code