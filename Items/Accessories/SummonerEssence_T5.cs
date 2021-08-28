using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class SummonerEssence_T5 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("True Soul Summoner's Essence");
			Tooltip.SetDefault("The visions manifest as all manner of familiar, and settle after a short fight.\nGrants +25% minion damage\nIncreases minion knockback by 10%\nGives +4 Minion Slots\nCurrent Tier: V");
		}
		
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 1;
			Item.accessory = true;
            Item.rare = ItemRarityID.Cyan;
			Item.value = Item.sellPrice(gold: 6, silver: 25); // Might be slightly off
        }
		
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.GetDamage(DamageClass.Summon) += 0.25f;
			player.minionKB += 0.10f;
			player.maxMinions += 4;
        }
		
        public override void AddRecipes()
        {
			CreateRecipe(1)
				.AddIngredient<SummonerEssence_T4>(1)
				.AddIngredient<MobSoul>(500)
				.AddIngredient(ItemID.BeetleHusk, 5)
				.AddTile(TileID.MythrilAnvil)
				.Register();
        }
    }
}