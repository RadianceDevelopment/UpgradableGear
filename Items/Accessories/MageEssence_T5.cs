using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class MageEssence_T5 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("True Soul Mage's Essence");
			Tooltip.SetDefault("The voices rage and argue, screaming to be released from their prison\nAfter pushing them back with your power, they grow silent, then start convulsing\nAfter awhile, the convulsion stop; and the Souls reveal their true form\nGrants +25% magic damage\nIncreases magical critical chance by 12%\nReduces mana usage by 20%\nCurrent Tier: V");
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
			player.magicDamage+= 0.25f;
			player.magicCrit+= 12;
			player.manaCost-= 0.15f;
        }
        public override void AddRecipes()
        {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("MageEssence_T4"), 1);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 25);
			recipe.AddIngredient(ItemID.FragmentNebula, 5);
			//recipe.AddTile(TileType<SoulInfuser>());
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}