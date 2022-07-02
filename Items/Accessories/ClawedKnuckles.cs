using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class ClawedKnuckles : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Clawed Knuckles");
			Tooltip.SetDefault("+4 Defense\n+12% Melee Speed\nA set of claws that have fleshy knuckles embedded into them\nCombining the two seems to prevent the rancid smell of flesh from attracting creatures");
		}
		
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 1;
			Item.accessory = true;
            Item.rare = ItemRarityID.Pink;
			Item.value = Item.sellPrice(gold: 9);
        }
		
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.statDefense+= 4;
			player.GetAttackSpeed(DamageClass.Melee)+= 0.12f;
        }
		
        public override void AddRecipes()
        {
			CreateRecipe(1)
				.AddIngredient(ItemID.FleshKnuckles)
				.AddIngredient(ItemID.FeralClaws)
				.AddTile(TileID.TinkerersWorkbench)
				.Register();
        }
    }
}