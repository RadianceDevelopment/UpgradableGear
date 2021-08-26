using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class MageEssence_T3 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Soul Mage's Essence III");
			Tooltip.SetDefault("You hear the Souls whispering...\nGrants +15% Magic Damage\nIncreases magical critical chance by 5%\nReduces mana usage by 6%\nCurrent Tier: III");
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
			player.magicDamage+= 0.15f;
			player.manaCost-= 0.06f;
			player.magicCrit+= 5;
        }
        public override void AddRecipes()
        {
			CreateRecipe(1)
				.AddIngredient(mod.GetItem("MageEssence_T2"), 1)
				.AddIngredient(mod.GetItem("MobSoul"), 15)
				.AddIngredient(ItemID.HellstoneBar, 3)
				.AddTile(TileID.Anvils)
				.Register();
        }
    }
}