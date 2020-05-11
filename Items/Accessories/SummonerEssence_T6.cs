using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class SummonerEssence_T6 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("True Soul Summoner's Essence");
			Tooltip.SetDefault("The visions subside as the essence convulses, revealing its true form\nGrants +30% minion damage\nGives +6 Minion Slots\nCurrent Tier: VI");
		}
		
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 1;
            item.value = Item.sellPrice(0, 30, 0, 0);
            item.rare = 10;
			item.accessory = true;
			item.expert = true;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.minionDamage+= 0.30f;
			player.maxMinions+= 6;
        }
        public override void AddRecipes()
        {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("SummonerEssence_T5"), 1);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 55);
			recipe.AddIngredient(ItemID.FragmentStardust, 7);
			//recipe.AddTile(TileType<SoulForge>());
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}