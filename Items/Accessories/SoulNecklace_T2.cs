using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class SoulNecklace_T2 : ModItem
	{
		public override void SetStaticDefaults() 
		{
		}
		
        public override void SetDefaults()
        {
            Item.width = 30;
            Item.height = 30;
            Item.maxStack = 1;
			Item.accessory = true;
            Item.rare = ItemRarityID.Blue;
			Item.value = Item.sellPrice(silver: 2);
        }
		
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.GetDamage(DamageClass.Summon) += 0.10f;
			player.GetKnockback(DamageClass.Summon).Base += 0.05f;
        }
		
        public override void AddRecipes()
        {
			CreateRecipe(1)
				.AddIngredient<StraySoul>(50)
				.AddIngredient<SoulNecklace_T1>(1)
                .AddIngredient(ItemID.DemoniteBar, 2)
                .AddIngredient(ItemID.Sapphire)
                .AddTile(TileID.Anvils)
				.Register();

            CreateRecipe(1)
                .AddIngredient<StraySoul>(50)
                .AddIngredient<SoulNecklace_T1>(1)
                .AddIngredient(ItemID.CrimtaneBar, 2)
                .AddIngredient(ItemID.Sapphire)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}