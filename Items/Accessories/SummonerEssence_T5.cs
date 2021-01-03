using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class SummonerEssence_T5 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Soul Summoner's Essence V");
			Tooltip.SetDefault("The visions grow more intense...\nGrants +25% minion damage\nGives +4 Minion Slots\nCurrent Tier: V");
		}
		
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 1;
            item.value = Item.sellPrice(0, 10, 0, 0);
            item.rare = 7;
			item.accessory = true;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.minionDamage+= 0.25f;
			player.maxMinions+= 4;
        }
        public override void AddRecipes()
        {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("SummonerEssence_T4"), 1);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 36);
			recipe.AddIngredient(ItemID.BeetleHusk, 5);
			//recipe.AddTile(TileType<SoulForge>());
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}