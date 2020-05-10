using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class SoulVessel1 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("First Soul Vessel Fragment");
			Tooltip.SetDefault("A fragment of something that holds great power over Souls\nOriginates from a far-away land\nIncreases maximum life by 5 when equipped");
		}
		
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 1;
            item.value = Item.sellPrice(0, 7, 50, 0);
            item.rare = 1;
			item.accessory = true;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.statLifeMax2+= 5;
        }
        public override void AddRecipes()
        {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 50);
			//recipe.AddTile(TileType<SoulForge>());
			recipe.AddTile(TileID.Furnaces);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}
// Totally not a Hollow Knight reference