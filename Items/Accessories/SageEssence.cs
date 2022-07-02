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
			Tooltip.SetDefault("The concentrated essence of a true warrior, born from the toil and labour of one.\nCan only be wielded by those who prove their worth in combat.\nDoubles all damage [Broken rn]\nGrants +25% Critical Chance\nReduces Mana Cost by 30%\n+35% Melee Speed\nIncreases minion knockback by 20%\n+10 Minion Slots\nThe souls now sing praises instead of lamenting their fate\nMost definitely cursed.\nCurrent Tier: XX");
		}
		
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 1;
			Item.accessory = true;
			Item.expertOnly = true;
            Item.rare = ItemRarityID.Purple;
			Item.value = Item.sellPrice(platinum: 1); // Probably not accurate but idrc, it's good enough
        }
		
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.GetDamage(DamageClass.Magic)  += 1.0f;
			player.GetDamage(DamageClass.Melee) += 1.0f; // Should double damage, but isn't... odd
			player.GetDamage(DamageClass.Ranged) += 1.0f;
			player.GetDamage(DamageClass.Summon) += 1.0f;
			
			player.GetCritChance(DamageClass.Magic) += 25;
			player.GetCritChance(DamageClass.Melee) += 25;
			player.GetCritChance(DamageClass.Ranged) += 25;
			
			player.manaCost -= 0.30f;
			player.GetAttackSpeed(DamageClass.Melee) += 0.35f;
			player.GetKnockback(DamageClass.Summon).Base += 0.20f;
			player.maxMinions += 10;
        }
		
        public override void AddRecipes()
        {
			CreateRecipe(1)
				.AddIngredient<MasterEssence>(1) // 26 Gold, 50 Silver
				.AddIngredient<FinalMagicToken>(1) // 10 Gold
				.AddIngredient<FinalMeleeToken>(1) // ~16 Gold, 60 Silver, 60 Copper (bit off cuz maths)
				.AddIngredient<FinalRangedToken>(1) // 15 Gold, 50 Silver
				.AddIngredient<FinalSummonerToken>(1) // 10 Gold
				.AddIngredient<MobSoul>(2500)
				.AddIngredient(ItemID.LunarBar, 10) // 12 Gold
				.AddIngredient(ItemID.FragmentNebula, 25) //# All frags add 5 gold (+20 total)
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