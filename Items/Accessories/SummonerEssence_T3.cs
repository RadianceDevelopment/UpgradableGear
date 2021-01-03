using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class SummonerEssence_T3 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Soul Summoner's Essence III");
			Tooltip.SetDefault("The noise grows louder...\nGrants +15% minion damage\nGives +2 Minion Slots\nCurrent Tier: III");
		}
		
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 1;
            item.value = Item.sellPrice(0, 4, 25, 0);
            item.rare = 3;
			item.accessory = true;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.minionDamage+= 0.15f;
			player.maxMinions+= 2;
        }
        public override void AddRecipes()
        {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("SummonerEssence_T2"), 1);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 18);
			recipe.AddIngredient(ItemID.HellstoneBar, 3);
			//recipe.AddTile(TileType<SoulForge>());
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}