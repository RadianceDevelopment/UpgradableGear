using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class SoulVessel2 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Vessel Fragment II");
			Tooltip.SetDefault("A fragment of something that holds great power over Souls\nOriginates from a far-away land\nIncreases maximum life by 15 when equipped");
		}
		
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 1;
			Item.accessory = true;
            Item.rare = ItemRarityID.Green;
			Item.value = Item.sellPrice(gold: 2);
        }
		
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.statLifeMax2+= 15;
        }
		
        public override void AddRecipes()
        {
			CreateRecipe(1)
				.AddIngredient<MobSoul>(50)
				.AddIngredient(ItemID.HellstoneBar, 5)
				.AddTile(TileID.Hellforge)
				.Register();
        }
    }
}
// Nope, this isn't a Hollow Knight reference. Not at all.