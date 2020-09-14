using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class SoulShield_T4 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Soul Shield IV");
			Tooltip.SetDefault("+12 Defense\nMonster souls that have been forced to protect you\nYou've compressed even more souls in, and realize that adding anymore will likely make the vessel inside the shield burst");
		}
		
        public override void SetDefaults()
        {
            item.width = 25;
            item.height = 25;
            item.maxStack = 1;
            item.value = Item.sellPrice(0, 16, 1, 85);
            item.rare = 10;
			item.accessory = true;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.statDefense+= 12;
        }
        public override void AddRecipes()
        {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("SoulShield_T3"));
			recipe.AddIngredient(mod.GetItem("MobSoul"), 75);
			recipe.AddIngredient(ItemID.LunarBar, 10);
			//recipe.AddTile(TileType<SoulForge>());
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}