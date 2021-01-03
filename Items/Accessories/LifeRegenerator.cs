using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class LifeRegenerator : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Life Regenerator");
			Tooltip.SetDefault("An ancient item made from two relics of the past\nImproves life regeneration and maximum health");
		}
		
        public override void SetDefaults()
        {
            item.width = 25;
            item.height = 25;
            item.maxStack = 1;
            item.value = Item.sellPrice(1, 0, 0, 0);
            item.rare = 10;
			item.accessory = true;
			item.expertOnly = true;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			// Band of Regen is 1
			player.lifeRegen+= 10;
			player.statLifeMax2+= 100;
        }
        public override void AddRecipes()
        {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("SoulVessel"), 1);
			recipe.AddIngredient(mod.GetItem("SoulRegen"), 1);
			//recipe.AddTile(TileType<SoulInfuser>());
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}