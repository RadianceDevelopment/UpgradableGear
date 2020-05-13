using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class WarriorEssence_T4 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Soul Warrior's Essence");
			Tooltip.SetDefault("The humming grows louder...\nGrants +20% melee damage and 15% melee speed\nBoosts melee critical chance by 5%\nCurrent Tier: IV");
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
			player.meleeDamage+= 0.20f;
			player.meleeSpeed+= 0.15f;
			player.meleeCrit+= 5;
        }
        public override void AddRecipes()
        {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("WarriorEssence_T3"), 1);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 20);
			recipe.AddIngredient(ItemID.ShroomiteBar, 4);
			//recipe.AddTile(TileType<SoulInfuser>());
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("WarriorEssence_T3"), 1);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 20);
			recipe.AddIngredient(ItemID.SpectreBar, 8);
			//recipe.AddTile(TileType<SoulInfuser>());
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}