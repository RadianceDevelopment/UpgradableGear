using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class SoulVessel : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Soul Vessel");
			Tooltip.SetDefault("Combining 3 Vessel Fragments allows you to imbue the items with the power of Soul\nAn ancient item from a far-away land\nIncreases maximum life by 100 when equipped");
		}
		
        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 30;
            item.maxStack = 1;
            item.value = Item.sellPrice(1, 0, 0, 0);
            item.rare = 10;
			item.accessory = true;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.statLifeMax2+= 100;
        }
        public override void AddRecipes()
        {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("SoulVessel1"), 1);
			recipe.AddIngredient(mod.GetItem("SoulVessel2"), 1);
			recipe.AddIngredient(mod.GetItem("SoulVessel3"), 1);
			recipe.AddIngredient(ItemID.Ectoplasm, 10);
			//recipe.AddTile(TileType<SoulForge>());
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}
// Yeah, this is a Hollow Knight reference and has been all along!
// So what?!