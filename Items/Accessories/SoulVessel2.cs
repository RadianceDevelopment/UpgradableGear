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
			Tooltip.SetDefault("A fragment of something that holds great power over Souls\nOriginates from a far-away land\nIncreases maximum life by 10 when equipped");
		}
		
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 1;
            item.value = Item.sellPrice(0, 15, 0, 0);
            item.rare = 3;
			item.accessory = true;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.statLifeMax2+= 10;
        }
        public override void AddRecipes()
        {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 50);
			recipe.AddIngredient(ItemID.HellstoneBar, 5);
			//recipe.AddTile(TileType<SoulForge>());
			recipe.AddTile(TileID.Hellforge);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}
// Nope, this isn't a Hollow Knight reference. Not at all.