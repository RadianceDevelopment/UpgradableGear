using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class MageEssence_T2 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Soul Mage's Essence II");
			Tooltip.SetDefault("The Souls stir, as if trying to converse with you...\nGrants +10% Magic Damage\nReduces mana usage by 3%\nCurrent Tier: II");
		}
		
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 1;
			Item.accessory = true;
            Item.rare = ItemRarityID.Blue;
			Item.value = Item.sellPrice(silver: 30);
        }
		
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.GetDamage(DamageClass.Magic) += 0.10f;
			player.manaCost-= 0.03f;
        }
		
        public override void AddRecipes()
        {
			CreateRecipe(1)
				.AddIngredient<MageEssence_T1>(1)
				.AddIngredient<MobSoul>(25)
				.AddIngredient(ItemID.Sapphire, 3)
				.AddTile(TileID.Anvils)
				.Register();
			
			CreateRecipe(1)
				.AddIngredient<MageEssence_T1>(1)
				.AddIngredient<MobSoul>(25)
				.AddIngredient(ItemID.Diamond, 1)
				.AddTile(TileID.Anvils)
				.Register();
        }
    }
}