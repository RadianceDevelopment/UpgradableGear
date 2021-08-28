using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class BasicSoulRegen : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Rudimentary Soul Regenerator");
			Tooltip.SetDefault("An ancient device thought to improve the users' ability to regenerate lost pieces of their Soul.\nIncreases life regen when equipped");
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
			// Band of Regen is 1
			player.lifeRegen+= 3;
        }
		
        public override void AddRecipes()
        {
			CreateRecipe(1)
				.AddIngredient(ItemID.BandofRegeneration, 1)
				.AddIngredient<MobSoul>(25)
				.AddIngredient(ItemID.GoldBar, 2)
				.AddTile(TileID.Anvils)
				.Register();
				
			CreateRecipe(1)
				.AddIngredient(ItemID.BandofRegeneration, 1)
				.AddIngredient<MobSoul>(25)
				.AddIngredient(ItemID.PlatinumBar, 2)
				.AddTile(TileID.Anvils)
				.Register();
        }
    }
}