using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class MythicRegenerator : ModItem
	{
		public override void SetStaticDefaults() 
		{
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
			// Band of Regen is 2
			player.lifeRegen += 8;
			player.statLifeMax2 += 150;
			player.potionDelayTime -= 1800; // Reduces potion sickness to 30 seconds.
        }
		
        public override void AddRecipes()
        {
			CreateRecipe(1)
				.AddIngredient<SoulRegenerator>(1)
				.AddIngredient(ItemID.CharmofMyths)
				.AddIngredient(ItemID.LunarBar, 3)
                .AddIngredient(ItemID.Sapphire, 2)
                .AddTile(TileID.TinkerersWorkbench)
				.Register();
        }
    }
}
// Thanks to absoluteaquarian for giving me the potion delay code
// Thanks to trivaxy for helping me fix the potion delay code
// (Those are their names on the TML discord)