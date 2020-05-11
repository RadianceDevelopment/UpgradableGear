using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class CombEssence : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Combatant's Essence");
			Tooltip.SetDefault("The concentrated essence of a great warrior.\nGrants +50% to all damage\nGrants +20% Critical Chance\nReduces Mana Cost by 25%\nIncreases Melee Speed by 20%\nGives +8 Minion Slots\nCurrent Tier: X");
		}
		
        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 30;
            item.maxStack = 1;
            item.value = Item.sellPrice(1, 0, 0, 0);
            item.rare = 10;
			item.accessory = true;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.magicDamage+= 0.50f;
			player.meleeDamage+= 0.50f;
			player.rangedDamage+= 0.50f;
			player.minionDamage+= 0.50f;
		
			player.thrownDamage+= 0.50f;
			
			player.magicCrit+= 20;
			player.meleeCrit+= 20;
			player.rangedCrit+= 20;
			
			player.thrownCrit+= 20;
			
			player.manaCost-= 0.25f;
			player.meleeSpeed+= 0.20f;
			player.maxMinions+= 8;
        }
        public override void AddRecipes()
        {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("MageEssence_T5"), 1);
			recipe.AddIngredient(mod.GetItem("RangerEssence_T5"), 1);
			recipe.AddIngredient(mod.GetItem("SummonerEssence_T6"), 1);
			recipe.AddIngredient(mod.GetItem("WarriorEssence_T5"), 1);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 250);
			recipe.AddIngredient(ItemID.LunarBar, 5);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}