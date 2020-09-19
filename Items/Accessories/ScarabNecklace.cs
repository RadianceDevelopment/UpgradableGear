using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class ScarabNecklace : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Scarab Necklace");
			Tooltip.SetDefault("A necklace combined with a scroll of power\nSure to bring the wearer great skill with their summons.\nIncreases minion damage and knockback by 25%\nAllows you to summon 2 extra minions");
		}
		
        public override void SetDefaults()
        {
            item.width = 25;
            item.height = 25;
            item.maxStack = 1;
            item.value = Item.sellPrice(0, 45, 0, 0);
            item.rare = 1;
			item.accessory = true;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.maxMinions+= 2;
			player.minionDamage += 0.25f;
			player.minionKB+= 0.25f; //Should be a bit more than the Hercules Beetle
        }
        public override void AddRecipes()
        {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PapyrusScarab, 1);
			recipe.AddIngredient(ItemID.PygmyNecklace, 1);
			//recipe.AddTile(TileType<SoulInfuser>());
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}