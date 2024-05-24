using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class SoulScarab : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("Scarab-Soul Necklace");
			// Tooltip.SetDefault("A necklace infused with spiritual powers.\nYou hear distant chanting while you wear it...\nIncreases minion damage and knockback by 25%\n+3 Max Minions");
		}
		
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 1;
			Item.accessory = true;
            Item.rare = ItemRarityID.Green;
			Item.value = Item.sellPrice(gold: 10);
        }
		
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.GetDamage(DamageClass.Summon) += 0.25f;
			player.GetKnockback(DamageClass.Summon).Base += 0.25f;
			player.maxMinions += 3;
        }
		
        public override void AddRecipes()
        {
			CreateRecipe(1)
				.AddIngredient<ScarabNecklace>(1)
				.AddIngredient<SoulNecklace_T3>(1)
				.AddIngredient<StraySoul>(100)
				.AddTile(TileID.TinkerersWorkbench)
				.Register();
        }
    }
}