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
            item.width = 20;
            item.height = 20;
            item.maxStack = 1;
            item.value = Item.sellPrice(0, 30, 0, 0);
            item.rare = 5;
			item.accessory = true;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.statLifeMax2+= 25;
        }
        public override void AddRecipes()
        {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 100);
			recipe.AddIngredient(ItemID.SoulofFright, 5);
			recipe.AddIngredient(ItemID.SoulofMight, 5);
			recipe.AddIngredient(ItemID.SoulofSight, 5);
			//recipe.AddTile(TileType<SoulForge>());
			// Thanks to Braycoe#3181 on the TML Discord for giving me the internal Tile ID for Hardmode Forges
			// Hardmode Forges
			recipe.AddTile(133);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}
// Ok maybe I am referencing Hollow Knight