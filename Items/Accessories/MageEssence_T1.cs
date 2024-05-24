using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class MageEssence_T1 : ModItem
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
            Item.rare = ItemRarityID.White;
			Item.value = Item.sellPrice(copper: 0);
        }
		
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.GetDamage(DamageClass.Magic) += 0.05f;
        }
				
        public override void AddRecipes()
        {
			CreateRecipe(1)
				.AddIngredient<StraySoul>(15)
				.AddTile(TileID.WorkBenches)
				.Register();
        }
    }
}