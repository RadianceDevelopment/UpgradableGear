using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class ClawedKnuckles_Soul : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Soulified Clawed Knuckles");
			Tooltip.SetDefault("+5 Defense\n+20% Melee Speed\nA set of claws that have fleshy knuckles embedded into them\nInfused with many souls to amplify its power\nStrange whispers seem to emanate from it....");
		}
		
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 1;
            Item.rare = 5;
			Item.accessory = true;
			Item.value = Item.sellPrice(gold: 10);
        }
		
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.statDefense+= 5;
			player.meleeSpeed+= 0.20f;
        }
		
        public override void AddRecipes()
        {
			CreateRecipe(1)
				.AddIngredient(ItemID.FleshKnuckles)
				.AddIngredient(ItemID.FeralClaws)
				.AddIngredient(mod.GetItem("MobSoul"), 100)
				.AddTile(TileID.TinkerersWorkbench)
				.Register();
			
			resultItem.CreateRecipe(1)
				.AddIngredient(mod.GetItem("ClawedKnuckles"))
				.AddIngredient(mod.GetItem("MobSoul"), 100)
				.AddTile(TileID.TinkerersWorkbench)
				.Register();
        }
    }
}