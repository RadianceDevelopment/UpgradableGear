using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class TrueCombEssence : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("True Combatant's Essence");
			Tooltip.SetDefault("The concentrated essence of a true warrior.\nGrants +100% to all damage\nGrants +30% Critical Chance\nReduces Mana Cost by 40%\nIncreases Melee Speed by 50%\nGives +10 Minion Slots\nCurrent Tier: Final");
		}
		
        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 30;
            item.maxStack = 1;
            item.value = Item.sellPrice(5, 0, 0, 0);
            item.rare = 10;
			item.accessory = true;
        }
		
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.magicDamage+= 1.0f;
			player.meleeDamage+= 1.0f;
			player.rangedDamage+= 1.0f;
			player.minionDamage+= 1.0f;
		
			player.thrownDamage+= 1.0f;
			
			player.magicCrit+= 30;
			player.meleeCrit+= 30;
			player.rangedCrit+= 30;
			
			player.thrownCrit+= 30;
			
			player.manaCost-= 0.40f;
			player.meleeSpeed+= 0.50f;
			player.maxMinions+= 10;
        }
		
        public override void AddRecipes()
        {
			
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("CombEssence"), 1);
			recipe.AddIngredient(mod.GetItem("FinalMagicToken"), 1);
			recipe.AddIngredient(mod.GetItem("FinalMeleeToken"), 1);
			recipe.AddIngredient(mod.GetItem("FinalRangedToken"), 1);
			recipe.AddIngredient(mod.GetItem("FinalSummonerToken"), 1);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 500);
			recipe.AddIngredient(ItemID.LunarBar, 10);
			recipe.AddIngredient(ItemID.FragmentNebula, 25);
			recipe.AddIngredient(ItemID.FragmentSolar, 25);
			recipe.AddIngredient(ItemID.FragmentVortex, 25);
			recipe.AddIngredient(ItemID.FragmentStardust, 25);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			/*
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("CombEssence"), 1);
			
			Might re-add
			recipe.AddIngredient(mod.GetItem("RangerEssence_T5"), 1);
			recipe.AddIngredient(mod.GetItem("SummonerEssence_T6"), 1);
			recipe.AddIngredient(mod.GetItem("WarriorEssence_T5"), 1);
			
			recipe.AddRecipeGroup("SoulSang:FinalMelee");
			
			recipe.AddIngredient(ItemID.SDMG, 1);
			recipe.AddIngredient(ItemID.Celebration, 1);
			recipe.AddIngredient(ItemID.LastPrism, 1);
			recipe.AddIngredient(ItemID.RainbowCrystal, 1);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 500);
			recipe.AddIngredient(ItemID.LunarBar, 10);
			recipe.AddIngredient(ItemID.FragmentNebula, 25);
			recipe.AddIngredient(ItemID.FragmentSolar, 25);
			recipe.AddIngredient(ItemID.FragmentVortex, 25);
			recipe.AddIngredient(ItemID.FragmentStardust, 25);
			
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			recipe.AddIngredient(ItemID.Meowmere, 1);
			recipe.AddIngredient(ItemID.Terrarian, 1);
			recipe.AddIngredient(ItemID.SDMG, 1);
			recipe.AddIngredient(ItemID.Celebration, 1);
			recipe.AddIngredient(ItemID.LastPrism, 1);
			recipe.AddIngredient(ItemID.RainbowCrystal, 1);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 500);
			recipe.AddIngredient(ItemID.LunarBar, 10);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
			*/
        }
    }
}
/* Groups:

Magic - Last Prism, Lunar Flare
Melee - Meowmere, Star Wrath, Terrarian
Ranged - S.D.M.G, Celebration
Summoner - Rainbow Crystal Staff, Lunar Portal Staff

*/