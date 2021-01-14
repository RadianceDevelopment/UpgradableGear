using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class SoulNecklace_T3 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Soul Necklace III");
			Tooltip.SetDefault("A necklace infused with Souls.\nBound to increase ones' spritual affinity.\nMore Souls have been focused into the central gem.\nIncreases minion damage by 25%\nIncreases minion knockback by 15%\nIncreases max minions by 2");
		}
		
        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 30;
            item.maxStack = 1;
            item.value = Item.sellPrice(0, 4, 0, 0);
            item.rare = 0;
			item.accessory = true;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.maxMinions+= 1;
			player.minionDamage += 0.25f;
			player.minionKB+= 0.15f; 
        }
        public override void AddRecipes()
        {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 100);
			recipe.AddIngredient(mod.GetItem("SoulNecklace_T2"), 1);
			//recipe.AddTile(TileType<SoulForge>());
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}
// Yeah, this is a Hollow Knight reference and has been all along!
// So what?! It's my favourite game of all time!