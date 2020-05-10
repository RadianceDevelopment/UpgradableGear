using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class SoulVessel1 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("First Soul Vessel");
			Tooltip.SetDefault("A simple vessel holding some Souls\nOriginates from a far-away land\nIncreases maximum life by 20");
		}
		
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 1;
            item.value = Item.sellPrice(0, 6, 0, 0);
            item.rare = 1;
			item.accessory = true;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.statLifeMax2+= 20;
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