using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class RangerEssence_T2 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Soul Sniper's Essence II");
			Tooltip.SetDefault("The Essence starts to hum...\nGrants +10% Ranged Damage\nBoosts ranged critical chance by 3%\nCurrent Tier: II");
		}
		
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 1;
            Item.rare = 2;
			Item.accessory = true;
			Item.value = Item.sellPrice(copper: 0);
        }
		
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			Player.GetDamage(DamageClass.Ranged) += 0.10f;
			player.rangedCrit+= 3;
        }
		
        public override void AddRecipes()
        {
			CreateRecipe(1)
				.AddIngredient(mod.GetItem("RangerEssence_T1"), 1)
				.AddIngredient(mod.GetItem("MobSoul"), 10)
				.AddIngredient(ItemID.Emerald, 3)
				.AddTile(TileID.Anvils)
				.Register();
			
			resultItem.CreateRecipe(1)
				.AddIngredient(mod.GetItem("RangerEssence_T1"), 1)
				.AddIngredient(mod.GetItem("MobSoul"), 10)
				.AddIngredient(ItemID.Diamond, 1)
				.AddTile(TileID.Anvils)
				.Register();
        }
    }
}