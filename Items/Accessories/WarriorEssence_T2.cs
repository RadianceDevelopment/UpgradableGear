using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class WarriorEssence_T2 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Soul Warrior's Essence II");
			Tooltip.SetDefault("The Essence begins to pulsate...\nGrants +10% melee damage and 5% melee speed\nCurrent Tier: II");
		}
		
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 1;
			Item.accessory = true;
            Item.rare = ItemRarityID.Blue;
			Item.value = Item.sellPrice(silver: 50);
        }
		
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.GetDamage(DamageClass.Melee) += 0.10f;
			player.meleeSpeed+= 0.05f;
        }
		
        public override void AddRecipes()
        {
			CreateRecipe(1)
				.AddIngredient<WarriorEssence_T1>(1)
				.AddIngredient<MobSoul>(25)
				.AddIngredient(ItemID.Ruby, 3)
				.AddTile(TileID.Anvils)
				.Register();
			
			CreateRecipe(1)
				.AddIngredient<WarriorEssence_T1>(1)
				.AddIngredient<MobSoul>(25)
				.AddIngredient(ItemID.Diamond, 1)
				.AddTile(TileID.Anvils)
				.Register();
        }
    }
}