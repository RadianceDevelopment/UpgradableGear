using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class SoulNecklace_T2 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Soul Necklace II");
			Tooltip.SetDefault("A necklace infused with Souls.\nBound to increase ones' spritual affinity.\nMore Souls have been focused into the central gem.\n+10% Minion Damage\nIncreases minion knockback by 10%");
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
			player.GetDamage(DamageClass.Summon) += 0.10f;
			player.minionKB+= 0.05f;
        }
		
        public override void AddRecipes()
        {
			CreateRecipe(1)
				.AddIngredient<MobSoul>(50)
				.AddIngredient<SoulNecklace_T1>(1)
				.AddTile(TileID.Anvils)
				.Register();
        }
    }
}