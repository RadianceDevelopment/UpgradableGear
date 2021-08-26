using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class SageEssence : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Soul Sage's Essence");
			Tooltip.SetDefault("The concentrated essence of a true warrior, born from the toil and labour of one\nCan only be wielded by those who prove their worth in combat.\nIncreases all damage by 75%\nGrants +20% Critical Chance\nReduces Mana Cost by 30%\n+35% Melee Speed\n+10 Minion Slots\nThe souls now sing praises instead of lamenting their fate");
		}
		
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 1;
            Item.rare = 10;
			Item.expert = true;
			Item.accessory = true;
			Item.expertOnly = true;
			Item.value = Item.sellPrice(gold: 25);
        }
		
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.magicDamage+= 0.75f;
			player.meleeDamage+= 0.75f;
			player.rangedDamage+= 0.75f;
			player.minionDamage+= 0.75f;
			
			player.magicCrit+= 20;
			player.meleeCrit+= 20;
			player.rangedCrit+= 20;
			
			player.manaCost-= 0.30f;
			player.meleeSpeed+= 0.35f;
			player.maxMinions+= 10;
        }
		
        public override void AddRecipes()
        {
			CreateRecipe(1)
				.AddIngredient(mod.GetItem("MasterEssence"), 1)
				.AddIngredient(mod.GetItem("SoulTargeter_T3"), 1)
				.AddIngredient(mod.GetItem("FinalMagicToken"), 1)
				.AddIngredient(mod.GetItem("FinalMeleeToken"), 1)
				.AddIngredient(mod.GetItem("FinalRangedToken"), 1)
				.AddIngredient(mod.GetItem("FinalSummonerToken"), 1)
				.AddIngredient(mod.GetItem("MobSoul"), 500)
				.AddIngredient(ItemID.LunarBar, 10)
				.AddIngredient(ItemID.FragmentNebula, 25)
				.AddIngredient(ItemID.FragmentSolar, 25)
				.AddIngredient(ItemID.FragmentVortex, 25)
				.AddIngredient(ItemID.FragmentStardust, 25)
				.AddTile(TileID.LunarCraftingStation)
				.Register();
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