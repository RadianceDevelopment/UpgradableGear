using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class SoulVessel1 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("Vessel Fragment I");
			// Tooltip.SetDefault("A fragment of something that holds great power over Souls\nOriginates from a far-away land\nIncreases maximum life by 5 when equipped");
		}
		
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 1;
			Item.accessory = true;
            Item.rare = ItemRarityID.Blue;
			Item.value = Item.sellPrice(copper: 0);
        }
		
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.statLifeMax2+= 5;
        }
		
        public override void AddRecipes()
        {
			CreateRecipe(1)
				.AddIngredient<StraySoul>(25)
				.AddTile(TileID.Furnaces)
				.Register();
        }
    }
}
// Totally not a Hollow Knight reference