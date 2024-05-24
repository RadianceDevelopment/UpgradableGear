using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class MasterEssence : ModItem
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
            Item.rare = ItemRarityID.Cyan;
			Item.value = Item.sellPrice(gold: 50);
        }
		
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.GetDamage(DamageClass.Magic) += 0.50f;
			player.GetDamage(DamageClass.Melee) += 0.50f;
			player.GetDamage(DamageClass.Ranged) += 0.50f;
			player.GetDamage(DamageClass.Summon) += 0.50f;
					
			player.GetCritChance(DamageClass.Magic) += 20;
			player.GetCritChance(DamageClass.Melee) += 20;
			player.GetCritChance(DamageClass.Ranged) += 20;
			
			player.manaCost -= 0.15f;
			player.GetAttackSpeed(DamageClass.Melee) += 0.25f;
			player.GetKnockback(DamageClass.Summon).Base += 0.15f;
			player.maxMinions += 8;
        }
		
        public override void AddRecipes()
        {
			CreateRecipe(1)
				.AddIngredient<MageEssence_T5>(1)
				.AddIngredient<RangerEssence_T5>(1)
				.AddIngredient<SummonerEssence_T5>(1)
				.AddIngredient<WarriorEssence_T5>(1)
				.AddIngredient<StraySoul>(1000)
				.AddIngredient(ItemID.BeetleHusk, 25)
				.AddTile(TileID.MythrilAnvil)
				.Register();
        }
    }
}