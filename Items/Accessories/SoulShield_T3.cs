using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class SoulShield_T3 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Soul Shield: Tier III");
			Tooltip.SetDefault("+8 Defense\nMonster souls that have been forced to protect you\nYou've squeezed a few more souls in, furthur improving provided protection");
		}
		
        public override void SetDefaults()
        {
            item.width = 25;
            item.height = 25;
            item.maxStack = 1;
            item.value = Item.sellPrice(0, 4, 1, 0);
            item.rare = 4;
			item.accessory = true;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.statDefense+= 8;
        }
        public override void AddRecipes()
        {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("SoulShield_T2"));
			recipe.AddIngredient(mod.GetItem("MobSoul"), 50);
			recipe.AddIngredient(ItemID.HallowedBar, 10);
			//recipe.AddTile(TileType<SoulForge>());
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}