using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class RangerEssence_T5 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("True Soul Sniper's Essence");
			Tooltip.SetDefault("The essence convulses for a moment, shoots a salvo of ectoplasm, then reveals its true form\nGrants +25% ranged damage\nBoosts ranged critical chance by 12%\nCurrent Tier: V");
		}
		
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 1;
            item.value = Item.sellPrice(0, 25, 0, 0);
            item.rare = 9;
			item.accessory = true;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.rangedDamage+= 0.25f;
			player.rangedCrit+= 12;
			// Add 20% reduced ammo usage
        }
        public override void AddRecipes()
        {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("RangerEssence_T4"), 1);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 40);
			recipe.AddIngredient(ItemID.FragmentVortex, 5);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}