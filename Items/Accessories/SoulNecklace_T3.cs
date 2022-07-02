using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class SoulNecklace_T3 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Soul Necklace III");
			Tooltip.SetDefault("A necklace infused with Souls.\nBound to increase ones' spritual affinity.\nMore Souls have been focused into the central gem.\n+25% Minion Damage\nIncreases minion knockback by 10%\n+1 Max Minion");
		}
		
        public override void SetDefaults()
        {
            Item.width = 30;
            Item.height = 30;
            Item.maxStack = 1;
			Item.accessory = true;
            Item.rare = ItemRarityID.White;
			Item.value = Item.sellPrice(silver: 2);
        }
		
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.GetDamage(DamageClass.Summon) += 0.15f;
			player.GetKnockback(DamageClass.Summon).Base+= 0.10f;
			player.maxMinions+= 1;
        }
		
        public override void AddRecipes()
        {
			CreateRecipe(1)
				.AddIngredient<MobSoul>(100)
				.AddIngredient<SoulNecklace_T2>(1)
				.AddTile(TileID.Anvils)
				.Register();
        }
    }
}