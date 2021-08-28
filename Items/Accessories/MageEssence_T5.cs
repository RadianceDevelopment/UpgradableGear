using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class MageEssence_T5 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("True Soul Mage's Essence");
			Tooltip.SetDefault("The voices rage and argue, screaming to be released from their prison\nAfter pushing them back with your power, they grow silent, then start convulsing\nAfter awhile, the convulsion stop; and the Souls reveal their true form\nGrants +25% Magic Damage\nIncreases magical critical chance by 8%\nReduces mana usage by 8%\nCurrent Tier: V");
		}
		
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 1;
			Item.accessory = true;
            Item.rare = ItemRarityID.Cyan;
			Item.value = Item.sellPrice(gold: 6, silver: 50);
        }
		
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.GetDamage(DamageClass.Magic) += 0.25f;
			player.GetCritChance(DamageClass.Magic) += 8;
			player.manaCost-= 0.12f;
        }
		
        public override void AddRecipes()
        {
			CreateRecipe(1)
				.AddIngredient<MageEssence_T4>(1)
				.AddIngredient<MobSoul>(500)
				.AddIngredient(ItemID.FragmentNebula, 5)
				.AddTile(TileID.LunarCraftingStation)
				.Register();
        }
    }
}