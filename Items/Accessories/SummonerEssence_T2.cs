using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class SummonerEssence_T2 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Soul Summoner's Essence");
			Tooltip.SetDefault("The Souls seem to be groaning in pain\nGrants +10% minion damage\nGives +1 Minion Slot\nCurrent Tier: II");
		}
		
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 1;
            item.value = Item.sellPrice(0, 0, 22, 0);
            item.rare = 2;
			item.accessory = true;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.minionDamage+= 0.10f;
			player.maxMinions+= 1;
        }
        public override void AddRecipes()
        {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("SummonerEssence_T1"), 1);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 14);
			recipe.AddIngredient(ItemID.Amethyst, 3);
			//recipe.AddTile(TileType<SoulInfuser>());
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}