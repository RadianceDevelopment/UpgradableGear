using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class MageEssence_T5 : ModItem
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
            Item.rare = ItemRarityID.Cyan;
			Item.value = Item.sellPrice(gold: 10);
        }
		
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.GetDamage(DamageClass.Magic) += 0.25f;
			player.GetCritChance(DamageClass.Magic) += 10;
			player.manaCost-= 0.12f;
        }
		
        public override void AddRecipes()
        {
			CreateRecipe(1)
				.AddIngredient<MageEssence_T4>(1)
				.AddIngredient<StraySoul>(500)
				.AddIngredient(ItemID.FragmentNebula, 10)
				.AddTile(TileID.LunarCraftingStation)
				.Register();
        }
    }
}