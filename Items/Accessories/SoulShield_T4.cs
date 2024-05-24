using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class SoulShield_T4 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("Soul Shield IV");
			// Tooltip.SetDefault("+12 Defense\nMonster souls that have been forced to protect you\nYou've compressed even more souls into this, and realize that adding anymore will likely make the shield's soul vessel");
		}
		
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 1;
			Item.accessory = true;
            Item.rare = ItemRarityID.Red;
			Item.value = Item.sellPrice(gold: 11, silver: 50);
        }
		
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.statDefense+= 12;
        }
		
        public override void AddRecipes()
        {
			CreateRecipe(1)
				.AddIngredient<SoulShield_T3>(1)
				.AddIngredient<StraySoul>(100)
				.AddIngredient(ItemID.LunarBar, 5)
				.AddTile(TileID.LunarCraftingStation)
				.Register();
        }
    }
}