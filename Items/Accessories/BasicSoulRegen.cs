using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class BasicSoulRegen : ModItem
	{
		public override void SetStaticDefaults() 
		{
		}
		
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 1;
			Item.accessory = true;
            Item.rare = ItemRarityID.Blue;
			Item.value = Item.sellPrice(gold: 1);
        }
		
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			// Band of Regen is 2
			player.lifeRegen+= 4;
        }
		
        public override void AddRecipes()
        {
			CreateRecipe(1)
				.AddIngredient(ItemID.BandofRegeneration)
				.AddIngredient<StraySoul>(35)
				.AddIngredient(ItemID.GoldBar, 3)
				.AddTile(TileID.TinkerersWorkbench)
				.Register();
				
			CreateRecipe(1)
				.AddIngredient(ItemID.BandofRegeneration)
				.AddIngredient<StraySoul>(35)
				.AddIngredient(ItemID.PlatinumBar, 3)
				.AddTile(TileID.TinkerersWorkbench)
				.Register();
        }
    }
}