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
			Tooltip.SetDefault("The humming intensifies...\nGrants +15% Ranged Damage\nBoosts ranged critical chance by 5%\nCurrent Tier: III");
		}
		
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 1;
            Item.rare = 4;
			Item.accessory = true;
			Item.value = Item.sellPrice(copper: 0);
        }
		
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			Player.GetDamage(DamageClass.Ranged) += 0.15f;
			player.rangedCrit+= 5;
        }
		
        public override void AddRecipes()
        {
			CreateRecipe(1)
				.AddIngredient(mod.GetItem("RangerEssence_T2"), 1)
				.AddIngredient(mod.GetItem("MobSoul"), 20)
				.AddIngredient(ItemID.HellstoneBar, 3)
				.AddTile(TileID.Anvils)
				.Register();
        }
    }
}