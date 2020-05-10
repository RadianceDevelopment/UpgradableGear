using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class SummonerEssence_T4 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Soul Summoner's Essence");
			Tooltip.SetDefault("Visions start to appear in your mind...\nGrants +20% minion damage\nGives +3 Minion Slots\nCurrent Tier: IV");
		}
		
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 1;
            item.value = Item.sellPrice(0, 7, 50, 0);
            item.rare = 4;
			item.accessory = true;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.minionDamage+= 0.20f;
			player.maxMinions+= 3;
        }
        public override void AddRecipes()
        {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("SummonerEssence_T3"), 1);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 30);
			recipe.AddIngredient(ItemID.MythrilBar, 5);
			//recipe.AddTile(TileType<SoulForge>());
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("SummonerEssence_T3"), 1);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 35);
			recipe.AddIngredient(ItemID.OrichalcumBar, 5);
			//recipe.AddTile(TileType<SoulForge>());
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}