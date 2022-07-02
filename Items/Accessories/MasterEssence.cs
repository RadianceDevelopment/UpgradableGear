using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class MasterEssence : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Soul Master's Essence");
			Tooltip.SetDefault("The concentrated essence of a great fighter.\nGrants +50% to all damage\nGrants +15% Critical Chance\nReduces Mana Cost by 20%\n+25% Melee Speed\nIncreases minion knockback by 15%\n+8 Minion Slots\nCurrent Tier: X");
		}
		
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 1;
			Item.accessory = true;
            Item.rare = ItemRarityID.Red;
			Item.value = Item.sellPrice(gold: 25);
        }
		
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.GetDamage(DamageClass.Magic) += 0.50f;
			player.GetDamage(DamageClass.Melee) += 0.50f;
			player.GetDamage(DamageClass.Ranged) += 0.50f;
			player.GetDamage(DamageClass.Summon) += 0.50f;
					
			player.GetCritChance(DamageClass.Magic) += 15;
			player.GetCritChance(DamageClass.Melee) += 15;
			player.GetCritChance(DamageClass.Ranged) += 15;
			
			player.manaCost -= 0.20f;
			player.GetAttackSpeed(DamageClass.Melee) += 0.25f;
			player.GetKnockback(DamageClass.Summon).Base += 0.15f;
			player.maxMinions += 8;
        }
		
        public override void AddRecipes()
        {
			CreateRecipe(1)
				.AddIngredient<MageEssence_T5>(1)  // 6 Gold 50 Silver
				.AddIngredient<RangerEssence_T5>(1) // 6 Gold 55 Silver
				.AddIngredient<SummonerEssence_T5>(1) // 6 Gold 25 Silver
				.AddIngredient<WarriorEssence_T5>(1) // 7 Gold 20 Silver
				.AddIngredient<MobSoul>(1000)
				.AddIngredient(ItemID.LunarBar, 1)
				.AddTile(TileID.LunarCraftingStation)
				.Register();
				// Might remove this alt recipe later
			CreateRecipe(1)
				.AddIngredient<MageEssence_T5>(1)  // 6 Gold 50 Silver
				.AddIngredient<RangerEssence_T5>(1) // 6 Gold 55 Silver
				.AddIngredient<SummonerEssence_T5>(1) // 6 Gold 25 Silver
				.AddIngredient<WarriorEssence_T5>(1) // 7 Gold 20 Silver
				.AddIngredient<MobSoul>(1500)
				.AddIngredient(ItemID.FragmentNebula, 50) //# All frags add 3 gold (+12 total)
				.AddIngredient(ItemID.FragmentSolar, 50)
				.AddIngredient(ItemID.FragmentVortex, 50)
				.AddIngredient(ItemID.FragmentStardust, 50)
				.AddTile(TileID.LunarCraftingStation)
				.Register();
        }
    }
}