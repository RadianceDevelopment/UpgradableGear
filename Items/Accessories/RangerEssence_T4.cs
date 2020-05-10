using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class RangerEssence_T4 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Soul Sniper's Essence");
			Tooltip.SetDefault("The essence starts to spew ghostly projectiles...\nGrants +20% ranged damage\nBoosts ranged critical chance by 8%\nCurrent Tier: IV");
		}
		
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 1;
            item.value = Item.sellPrice(0, 12, 0, 0);
            item.rare = 6;
			item.accessory = true;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.rangedDamage+= 0.20f;
			player.rangedCrit+= 8;
			// Add 10% reduced ammo usage
        }
        public override void AddRecipes()
        {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("RangerEssence_T3"), 1);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 35);
			recipe.AddIngredient(ItemID.ShroomiteBar, 4);
			//recipe.AddTile(TileType<SoulForge>());
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}