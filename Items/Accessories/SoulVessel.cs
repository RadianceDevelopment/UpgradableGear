using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class SoulVessel : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("Soul Vessel");
			// Tooltip.SetDefault("Combining 3 Vessel Fragments allows you to imbue the fragments with the power of Soul\nAn ancient Item from a far-away land\nIncreases maximum life by 100 when equipped");
		}
		
        public override void SetDefaults()
        {
            Item.width = 30;
            Item.height = 30;
            Item.maxStack = 1;
			Item.accessory = true;
            Item.rare = ItemRarityID.Yellow;
			Item.value = Item.sellPrice(gold: 15);
        }
		
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.statLifeMax2+= 100;
        }
		
        public override void AddRecipes()
        {
			CreateRecipe(1)
				.AddIngredient<SoulVessel1>(1)
				.AddIngredient<SoulVessel2>(1)
				.AddIngredient<SoulVessel3>(1)
				.AddIngredient<StraySoul>(150)
				.AddIngredient(ItemID.Ectoplasm, 10)
				.AddTile(TileID.TinkerersWorkbench)
				.Register();
        }
    }
}
// It's a Hollow Knight reference?
// *Always has been*