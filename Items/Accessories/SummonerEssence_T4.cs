using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class SummonerEssence_T4 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("Soul Summoner's Essence IV");
			// Tooltip.SetDefault("Visions start to appear in your mind...\nGrants +20% minion damage\nIncreases minion knockback by 7%\nGives +3 Minion Slots\nCurrent Tier: IV");
		}
		
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 1;
			Item.accessory = true;
            Item.rare = ItemRarityID.LightRed;
			Item.value = Item.sellPrice(gold: 3, silver: 75);
        }
		
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.GetDamage(DamageClass.Summon) += 0.20f;
			player.GetKnockback(DamageClass.Summon).Base += 0.07f;
			player.maxMinions += 3;
        }
		
        public override void AddRecipes()
        {
			CreateRecipe(1)
				.AddIngredient<SummonerEssence_T3>(1)
				.AddIngredient<StraySoul>(225)
				.AddIngredient(ItemID.MythrilBar, 5)
				.AddTile(TileID.MythrilAnvil)
				.Register();
			
			CreateRecipe(1)
				.AddIngredient<SummonerEssence_T3>(1)
				.AddIngredient<StraySoul>(225)
				.AddIngredient(ItemID.OrichalcumBar, 5)
				.AddTile(TileID.MythrilAnvil)
				.Register();
        }
    }
}