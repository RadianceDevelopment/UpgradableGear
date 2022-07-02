using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class SummonerEssence_T3 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Soul Summoner's Essence III");
			Tooltip.SetDefault("The noise grows louder...\nGrants +15% minion damage\nIncreases minion knockback by 5%\nGives +2 Minion Slots\nCurrent Tier: III");
		}
		
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 1;
			Item.accessory = true;
            Item.rare = ItemRarityID.Orange;
			Item.value = Item.sellPrice(gold: 1, silver: 55);
        }
		
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.GetDamage(DamageClass.Summon) += 0.15f;
			player.GetKnockback(DamageClass.Summon).Base += 0.05f;
			player.maxMinions += 2;
        }
		
        public override void AddRecipes()
        {
			CreateRecipe(1)
				.AddIngredient<SummonerEssence_T2>(1)
				.AddIngredient<MobSoul>(75)
				.AddIngredient(ItemID.HellstoneBar, 3)
				.AddTile(TileID.Anvils)
				.Register();
        }
    }
}