using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class WarriorEssence_T5 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("True Soul Warrior's Essence");
			Tooltip.SetDefault("The Essence twists and convulses, then reveals its true form\nGrants +25% melee damage and +12% melee speed\nBoosts melee critical chance by 7%\nCurrent Tier: V");
		}
		
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 1;
            item.value = Item.sellPrice(0, 25, 0, 0);
            item.rare = 9;
			item.accessory = true;
			item.expert = true;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.meleeDamage+= 0.25f;
			player.meleeSpeed+= 0.12f;
			player.meleeCrit+= 7;
        }
        public override void AddRecipes()
        {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("WarriorEssence_T4"), 1);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 25);
			recipe.AddIngredient(ItemID.FragmentSolar, 5);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}