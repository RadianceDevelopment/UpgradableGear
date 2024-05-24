using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class SoulShield_T2 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("Soul Shield II");
			// Tooltip.SetDefault("+4 Defense\nMonster souls that have been forced to protect you\nYou've added more souls into the mix, improving the defense provided");
		}
		
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 1;
			Item.accessory = true;
            Item.rare = ItemRarityID.Blue;
			Item.value = Item.sellPrice(gold: 1, silver: 50);
        }
		
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.statDefense+= 4;
        }
		
        public override void AddRecipes()
        {
			CreateRecipe(1)
				.AddIngredient<SoulShield_T1>(1)
				.AddIngredient<StraySoul>(35)
				.AddIngredient(ItemID.DemoniteBar, 5)
				.AddTile(TileID.Anvils)
				.Register();
			
			CreateRecipe(1)
				.AddIngredient<SoulShield_T1>(1)
				.AddIngredient<StraySoul>(35)
				.AddIngredient(ItemID.CrimtaneBar, 5)
				.AddTile(TileID.Anvils)
				.Register();
        }
    }
}