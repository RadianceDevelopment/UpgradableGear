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
			Tooltip.SetDefault("The concentrated essence of a true warrior, born from the toil and labour of one\nIncreases all damage by 150%\nGrants +35% Critical Chance\nReduces Mana Cost by 50%\nIncreases Melee Speed by 50%\nGives +10 Minion Slots\nCurrent Tier: True Final");
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
			player.magicDamage+= 1.5f;
			player.meleeDamage+= 1.5f;
			player.rangedDamage+= 1.5f;
			player.minionDamage+= 1.5f;
		
			player.thrownDamage+= 1.5f;
			
			player.magicCrit+= 35;
			player.meleeCrit+= 35;
			player.rangedCrit+= 35;
			
			player.thrownCrit+= 35;
			
			player.manaCost-= 0.50f;
			player.meleeSpeed+= 0.50f;
			player.maxMinions+= 10;
        }
		
        public override void AddRecipes()
        {
			
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("CombEssence"), 1);
			recipe.AddIngredient(mod.GetItem("SoulTargeter_T3"), 1);
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
			
        }
    }
}
/* Groups:

When I can make Recipe Groups work, I'll use these instead of those token items

Magic - Last Prism, Lunar Flare
Melee - Meowmere, Star Wrath, Terrarian
Ranged - S.D.M.G, Celebration
Summoner - Rainbow Crystal Staff, Lunar Portal Staff

*/