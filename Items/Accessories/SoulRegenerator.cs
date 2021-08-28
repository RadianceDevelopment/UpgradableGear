using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class SoulRegenerator : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Soul Regenerator");
			Tooltip.SetDefault("An ancient item made from two relics of the past\nImproves life regeneration and maximum health");
		}
		
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 1;
			Item.accessory = true;
            Item.rare = ItemRarityID.Cyan;
			Item.value = Item.sellPrice(gold: 20);
        }
		
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			// Band of Regen is 1
			player.lifeRegen+= 6;
			player.statLifeMax2+= 125;
        }
		
        public override void AddRecipes()
        {
			CreateRecipe(1)
				.AddIngredient<SoulVessel>(1)
				.AddIngredient<BasicSoulRegen>(1)
				.AddIngredient(ItemID.HallowedBar, 3)
				.AddTile(TileID.TinkerersWorkbench)
				.Register();
        }
    }
}