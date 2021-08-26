using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class WarriorEssence_T4 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Soul Warrior's Essence IV");
			Tooltip.SetDefault("The humming grows louder...\nGrants +20% melee damage and 15% melee speed\nBoosts melee critical chance by 5%\nCurrent Tier: IV");
		}
		
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 1;
            Item.rare = 6;
			Item.accessory = true;
			Item.value = Item.sellPrice(gold: 8);
        }
		
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			Player.GetDamage(DamageClass.Melee) += 0.20f;
			player.meleeSpeed+= 0.15f;
			player.meleeCrit+= 5;
        }
		
        public override void AddRecipes()
        {
			CreateRecipe(1)
				.AddIngredient(mod.GetItem("WarriorEssence_T3"), 1)
				.AddIngredient(mod.GetItem("MobSoul"), 20)
				.AddIngredient(ItemID.ShroomiteBar, 4)
				.AddIngredient(ItemID.SpectreBar, 4)
				.AddTile(TileID.MythrilAnvil)
				.Register();
        }
    }
}