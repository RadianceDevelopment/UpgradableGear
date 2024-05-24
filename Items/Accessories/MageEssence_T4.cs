using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class MageEssence_T4 : ModItem
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
            Item.rare = ItemRarityID.Yellow;
			Item.value = Item.sellPrice(gold: 5);
        }
		
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.GetDamage(DamageClass.Magic) += 0.20f;
			player.GetCritChance(DamageClass.Magic) += 5;
			player.manaCost -= 0.08f;
        }
		
        public override void AddRecipes()
        {
			CreateRecipe(1)
				.AddIngredient<MageEssence_T3>(1)
				.AddIngredient<StraySoul>(225)
				.AddIngredient(ItemID.SpectreBar, 4)
				.AddTile(TileID.MythrilAnvil)
				.Register();
        }
    }
}