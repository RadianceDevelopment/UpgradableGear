using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class RangerEssence_T2 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("Soul Sniper's Essence II");
			// Tooltip.SetDefault("The Essence starts to hum...\nGrants +10% Ranged Damage\nCurrent Tier: II");
		}
		
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 1;
			Item.accessory = true;
            Item.rare = ItemRarityID.Blue;
			Item.value = Item.sellPrice(silver: 35);
        }
		
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.GetDamage(DamageClass.Ranged) += 0.10f;
        }
		
        public override void AddRecipes()
        {
			CreateRecipe(1)
				.AddIngredient<RangerEssence_T1>(1)
				.AddIngredient<StraySoul>(40)
				.AddIngredient(ItemID.Emerald, 3)
				.AddTile(TileID.Anvils)
				.Register();
			
			CreateRecipe(1)
				.AddIngredient<RangerEssence_T1>(1)
				.AddIngredient<StraySoul>(25)
				.AddIngredient(ItemID.Diamond, 1)
				.AddTile(TileID.Anvils)
				.Register();
        }
    }
}