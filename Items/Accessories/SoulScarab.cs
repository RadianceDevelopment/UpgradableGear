using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class SoulScarab : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Soulified Scarab Necklace");
			Tooltip.SetDefault("A necklace infused with spiritual powers.\nYou hear distant chanting while you wear it...\nIncreases minion damage and knockback by 25%\nAllows you to summon 3 extra minions");
		}
		
        public override void SetDefaults()
        {
            item.width = 25;
            item.height = 25;
            item.maxStack = 1;
            item.value = Item.sellPrice(0, 15, 50, 0);
            item.rare = 1;
			item.accessory = true;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.maxMinions+= 3;
			player.minionDamage += 0.25;
			player.minionKB+= 0.25; // A bit more than the Scarab Necklace (+25%)
        }
        public override void AddRecipes()
        {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("ScarabNecklace"), 1);
			recipe.AddIngredient(mod.GetItem("SoulNecklace_T3"), 1);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 150);
			//recipe.AddTile(TileType<SoulInfuser>());
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}