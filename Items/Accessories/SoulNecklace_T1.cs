using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class SoulNecklace_T1 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Soul Necklace I");
			Tooltip.SetDefault("A necklace infused with Souls.\nBound to increase ones' spritual affinity.\n+5% Minion Damage\nIncreases minion knockback by 5%");
		}
		
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 1;
			Item.accessory = true;
            Item.rare = ItemRarityID.White;
			Item.value = Item.sellPrice(silver: 2);
        }
		
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.GetDamage(DamageClass.Summon) += 0.05f;
        }
		
        public override void AddRecipes()
        {
			CreateRecipe(1)
				.AddIngredient<MobSoul>(25)
				.AddIngredient(ItemID.Chain, 5)
				.AddTile(TileID.Anvils)
				.Register();
        }
    }
}