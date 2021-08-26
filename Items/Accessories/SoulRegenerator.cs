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
            Item.width = 25;
            Item.height = 25;
            Item.maxStack = 1;
            Item.rare = 10;
			Item.accessory = true;
			Item.expertOnly = true;
			Item.value = Item.sellPrice(platinum: 1);
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			// Band of Regen is 1
			player.lifeRegen+= 10;
			player.statLifeMax2+= 75;
        }
        public override void AddRecipes()
        {
			CreateRecipe(1)
				.AddIngredient(mod.GetItem("SoulVessel"), 1)
				.AddIngredient(mod.GetItem("SoulRegen"), 1)
				.AddTile(TileID.TinkerersWorkbench)
				.Register();
        }
    }
}