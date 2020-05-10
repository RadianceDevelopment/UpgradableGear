using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class RangerEssence_T3 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Soul Sniper's Essence");
			Tooltip.SetDefault("The humming intensifies...\nGrants +15% ranged damage\nBoosts ranged critical chance by 5%\nCurrent Tier: III");
		}
		
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 1;
            item.value = Item.sellPrice(0, 4, 0, 0);
            item.rare = 4;
			item.accessory = true;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.rangedDamage+= 0.15f;
			player.rangedCrit+= 5;
        }
        public override void AddRecipes()
        {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("RangerEssence_T2"), 1);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 20);
			recipe.AddIngredient(ItemID.HellstoneBar, 3);
			//recipe.AddTile(TileType<SoulInfuser>());
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}