using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class ScarabNecklace : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Scarab Necklace");
			Tooltip.SetDefault("A necklace combined with a scroll of power\nSure to bring the wearer great skill with their summons.\nIncreases minion damage and knockback by 20%\n+2 Max Minions");
		}
		
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 1;
			Item.accessory = true;
            Item.rare = ItemRarityID.Blue;
			Item.value = Item.sellPrice(gold: 9);
        }
		
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.GetDamage(DamageClass.Summon) += 0.20f;
			player.GetKnockback(DamageClass.Summon).Base+= 0.20f; // Should be a bit more than (or equal to) the Hercules Beetle
			player.maxMinions+= 2;
        }
		
        public override void AddRecipes()
        {
			CreateRecipe(1)
				.AddIngredient(ItemID.PapyrusScarab, 1)
				.AddIngredient(ItemID.PygmyNecklace, 1)
				.AddTile(TileID.TinkerersWorkbench)
				.Register();
        }
    }
}