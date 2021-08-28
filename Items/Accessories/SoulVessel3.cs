using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class SoulVessel3 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Vessel Fragment III");
			Tooltip.SetDefault("A fragment of something that holds great power over Souls\nOriginates from a far-away land\nIncreases maximum life by 25 when equipped");
		}
		
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 1;
			Item.accessory = true;
            Item.rare = ItemRarityID.Pink;
			Item.value = Item.sellPrice(gold: 10);
        }
		
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.statLifeMax2+= 25;
        }
		
        public override void AddRecipes()
        {
			CreateRecipe(1)
				.AddIngredient<MobSoul>(100)
				.AddIngredient(ItemID.SoulofFright, 10)
				// Hardmode Forges
				.AddTile(133)
				.Register();
				
			CreateRecipe(1)
				.AddIngredient<MobSoul>(100)
				.AddIngredient(ItemID.SoulofMight, 10)
				// Hardmode Forges
				.AddTile(133)
				.Register();
				
			CreateRecipe(1)
				.AddIngredient<MobSoul>(100)
				.AddIngredient(ItemID.SoulofSight, 10)
				// Hardmode Forges
				.AddTile(133)
				.Register();
        }
    }
}
// Ok maybe I am referencing Hollow Knight