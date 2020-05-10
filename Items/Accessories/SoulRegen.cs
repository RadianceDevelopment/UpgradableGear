using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class SoulRegen : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Soul Regenerator");
			Tooltip.SetDefault("A device thought to improve the users' ability to regenerate lost pieces of their Soul.\nIncreases life regen when equipped");
		}
		
        public override void SetDefaults()
        {
            item.width = 25;
            item.height = 25;
            item.maxStack = 1;
            item.value = Item.sellPrice(0, 30, 0, 0);
            item.rare = 5;
			item.accessory = true;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			// Band of Regen is 1
			player.lifeRegen+= 2;
        }
        public override void AddRecipes()
        {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BandofRegeneration, 1);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 15);
			//recipe.AddTile(TileType<SoulInfuser>());
			// Thanks to Braycoe#3181 on the TML Discord for giving me the internal ID for Hardmode Forges
			// Hardmode Forges
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}
// Ok maybe I am referencing Hollow Knight