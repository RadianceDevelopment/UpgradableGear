using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class ScarabNecklace : ModItem
	{
		public override void SetStaticDefaults() 
		{
		}
		
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 1;
			Item.accessory = true;
            Item.rare = ItemRarityID.Blue;
			Item.value = Item.sellPrice(gold: 10);
        }
		
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.GetDamage(DamageClass.Summon) += 0.17f;
			player.GetKnockback(DamageClass.Summon).Base += 0.15f; // Should be roughly equal to the Hercules Beetle
			player.maxMinions += 2;
        }
		
        public override void AddRecipes()
        {
			CreateRecipe(1)
				.AddIngredient(ItemID.PapyrusScarab)
				.AddIngredient(ItemID.PygmyNecklace)
				.AddTile(TileID.TinkerersWorkbench)
				.Register();
        }
    }
}