using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class SummonerEssence_T2 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Soul Summoner's Essence II");
			Tooltip.SetDefault("The Souls seem to be groaning in pain\nGrants +10% minion damage\nGives +1 Minion Slot\nCurrent Tier: II");
		}
		
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 1;
			Item.accessory = true;
            Item.rare = ItemRarityID.Blue;
			Item.value = Item.sellPrice(silver: 35);
        }
		
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.GetDamage(DamageClass.Summon) += 0.10f;
			player.maxMinions += 1;
        }
		
        public override void AddRecipes()
        {
			CreateRecipe(1)
				.AddIngredient<SummonerEssence_T1>(1)
				.AddIngredient<MobSoul>(25)
				.AddIngredient(ItemID.Amethyst, 3)
				.AddTile(TileID.Anvils)
				.Register();
			
			CreateRecipe(1)
				.AddIngredient<SummonerEssence_T1>(1)
				.AddIngredient<MobSoul>(25)
				.AddIngredient(ItemID.Diamond, 1)
				.AddTile(TileID.Anvils)
				.Register();
        }
    }
}