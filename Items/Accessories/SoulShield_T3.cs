using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class SoulShield_T3 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("Soul Shield III");
			// Tooltip.SetDefault("+8 Defense\nMonster souls that have been forced to protect you\nYou've squeezed a few more souls in, furthur improving provided protection");
		}
		
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 1;
			Item.accessory = true;
            Item.rare = ItemRarityID.LightRed;
			Item.value = Item.sellPrice(gold: 5, silver: 50);
        }
		
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.statDefense+= 8;
        }
		
        public override void AddRecipes()
        {
			CreateRecipe(1)
				.AddIngredient<SoulShield_T2>(1)
				.AddIngredient<StraySoul>(60)
				.AddIngredient(ItemID.HallowedBar, 10)
				.AddTile(TileID.MythrilAnvil)
				.Register();
        }
    }
}