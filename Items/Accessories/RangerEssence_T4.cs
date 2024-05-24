using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class RangerEssence_T4 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("Soul Sniper's Essence IV");
			// Tooltip.SetDefault("The essence starts to spew ghostly projectiles...\nGrants +20% Ranged Damage\nBoosts ranged critical chance by 5%\nCurrent Tier: IV");
		}
		
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 1;
			Item.accessory = true;
            Item.rare = ItemRarityID.Yellow;
			Item.value = Item.sellPrice(gold: 5, silver: 55);
        }
		
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.GetDamage(DamageClass.Ranged) += 0.20f;
			player.GetCritChance(DamageClass.Ranged) += 5;
			// Add 10% reduced ammo usage
        }
		
        public override void AddRecipes()
        {
			CreateRecipe(1)
				.AddIngredient<RangerEssence_T3>(1)
				.AddIngredient<StraySoul>(225)
				.AddIngredient(ItemID.ShroomiteBar, 5)
				.AddTile(TileID.MythrilAnvil)
				.Register();
        }
    }
}