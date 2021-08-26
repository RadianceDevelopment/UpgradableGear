using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class WarriorEssence_T3 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Soul Warrior's Essence III");
			Tooltip.SetDefault("The Essence starts to hum, as if preparing for something...\nGrants +15% melee damage and 10% melee speed\nBoosts melee critical chance by 3%\nCurrent Tier: III");
		}
		
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 1;
            Item.rare = 4;
			Item.accessory = true;
			Item.value = Item.sellPrice(copper: 12000);
        }
		
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			Player.GetDamage(DamageClass.Melee) += 0.15f;
			player.meleeSpeed+= 0.10f;
			player.meleeCrit+= 3;
        }
		
        public override void AddRecipes()
        {
			CreateRecipe(1)
				.AddIngredient(mod.GetItem("WarriorEssence_T2"), 1)
				.AddIngredient(mod.GetItem("MobSoul"), 15)
				.AddIngredient(ItemID.HellstoneBar, 3)
				.AddTile(TileID.Anvils)
				.Register();
        }
    }
}