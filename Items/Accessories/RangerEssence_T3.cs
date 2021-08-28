using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class RangerEssence_T3 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Soul Sniper's Essence III");
			Tooltip.SetDefault("The humming intensifies...\nGrants +15% Ranged Damage\nBoosts ranged critical chance by 3%\nCurrent Tier: III");
		}
		
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 1;
			Item.accessory = true;
            Item.rare = ItemRarityID.Orange;
			Item.value = Item.sellPrice(gold: 1, silver: 55);
        }
		
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.GetDamage(DamageClass.Ranged) += 0.15f;
			player.GetCritChance(DamageClass.Ranged) += 3;
        }
		
        public override void AddRecipes()
        {
			CreateRecipe(1)
				.AddIngredient<RangerEssence_T2>(1)
				.AddIngredient<MobSoul>(75)
				.AddIngredient(ItemID.HellstoneBar, 3)
				.AddTile(TileID.Anvils)
				.Register();
        }
    }
}