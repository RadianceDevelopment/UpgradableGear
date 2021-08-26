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
			Tooltip.SetDefault("A necklace infused with Souls.\nBound to increase ones' spritual affinity.\nIncreases minion damage by 10%\nIncreases minion knockback by 5%");
		}
		
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 1;
            Item.rare = 0;
			Item.accessory = true;
			Item.value = Item.buyPrice(silver: 2);
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.minionDamage += 0.10f;
			player.minionKB+= 0.05f; 
        }
        public override void AddRecipes()
        {
			CreateRecipe(1)
				.AddIngredient(mod.GetItem("MobSoul"), 100)
				.AddIngredient(ItemID.Chain, 5)
				.AddTile(TileID.Anvils)
				.Register();
        }
    }
}
// Yeah, this is a Hollow Knight reference and has been all along!
// So what?! It's my favourite game of all time!