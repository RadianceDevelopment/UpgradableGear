using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using SoulSang.Global;

namespace SoulSang.Items.Accessories
{
	public class SageEssence : ModItem
	{
		public override void SetStaticDefaults() 
		{
		}
		
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 1;
			Item.accessory = true;
            Item.rare = ItemRarityID.Purple;
			Item.value = Item.sellPrice(platinum: 1);
        }
		
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.GetDamage(DamageClass.Magic) += 1.0f;
			player.GetDamage(DamageClass.Melee) += 1.0f; // Should double damage, but isn't... odd
			player.GetDamage(DamageClass.Ranged) += 1.0f;
			player.GetDamage(DamageClass.Summon) += 1.0f;
			
			player.GetCritChance(DamageClass.Magic) += 25;
			player.GetCritChance(DamageClass.Melee) += 25;
			player.GetCritChance(DamageClass.Ranged) += 25;
			
			player.manaCost -= 0.20f;
			player.GetAttackSpeed(DamageClass.Melee) += 0.35f;
			player.GetKnockback(DamageClass.Summon).Base += 0.20f;
			player.maxMinions += 10;
        }
		
        public override void AddRecipes()
        {
            CreateRecipe(1)
				.AddIngredient<MasterEssence>(1)
				.AddRecipeGroup("SoulSang:FinalMagic")
				//.AddIngredient<FinalMagicToken>(1)
				//.AddIngredient<FinalMeleeToken>(1)
				//.AddIngredient<FinalRangedToken>(1)
				//.AddIngredient<FinalSummonerToken>(1)
				.AddIngredient<StraySoul>(2500)
				.AddIngredient(ItemID.LunarBar, 10)
				.AddTile(TileID.LunarCraftingStation)
				.Register();
        }
    }
}
/* Groups:

When I can make Recipe Groups work, I'll use these instead of those token items

Magic - Last Prism, Lunar Flare
Melee - Meowmere, Star Wrath, Terrarian
Ranged - S.D.M.G, Celebration Mk 2
Summoner - Rainbow Crystal Staff, Lunar Portal Staff

*/