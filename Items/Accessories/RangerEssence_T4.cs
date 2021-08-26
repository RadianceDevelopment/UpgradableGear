using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class RangerEssence_T4 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Soul Sniper's Essence IV");
			Tooltip.SetDefault("The essence starts to spew ghostly projectiles...\nGrants +20% Ranged Damage\nBoosts ranged critical chance by 8%\nCurrent Tier: IV");
		}
		
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 1;
            Item.rare = 6;
			Item.accessory = true;
			Item.value = Item.sellPrice(copper: 0);
        }
		
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			Player.GetDamage(DamageClass.Ranged) += 0.20f;
			player.rangedCrit+= 8;
			// Add 10% reduced ammo usage
        }
		
        public override void AddRecipes()
        {
			CreateRecipe(1)
				.AddIngredient(mod.GetItem("RangerEssence_T3"), 1)
				.AddIngredient(mod.GetItem("MobSoul"), 30)
				.AddIngredient(ItemID.ShroomiteBar, 4)
				.AddTile(TileID.MythrilAnvil)
				.Register();
        }
    }
}