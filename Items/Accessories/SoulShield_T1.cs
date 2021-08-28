using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class SoulShield_T1 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Soul Shield I");
			Tooltip.SetDefault("+2 Defense\nMonster souls that have been forced to protect you");
		}
		
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 1;
			Item.accessory = true;
            Item.rare = ItemRarityID.White;
			Item.value = Item.sellPrice(copper: 0);
        }
		
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.statDefense+= 2;
        }
		
        public override void AddRecipes()
        {
			CreateRecipe(1)
				.AddIngredient<MobSoul>(20)
				.AddTile(TileID.Anvils)
				.Register();
        }
    }
}