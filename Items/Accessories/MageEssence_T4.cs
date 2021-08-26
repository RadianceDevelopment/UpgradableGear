using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class MageEssence_T4 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Soul Mage's Essence IV");
			Tooltip.SetDefault("The whispers grow into audible voices...\nGrants +20% Magic Damage\nIncreases magical critical chance by 8%\nReduces mana usage by 10%\nCurrent Tier: IV");
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
			player.magicDamage+= 0.20f;
			player.manaCost-= 0.10f;
			player.magicCrit+= 8;
        }
        public override void AddRecipes()
        {
			CreateRecipe(1)
				.AddIngredient(mod.GetItem("MageEssence_T3"), 1)
				.AddIngredient(mod.GetItem("MobSoul"), 20)
				.AddIngredient(ItemID.SpectreBar, 4)
				.AddTile(TileID.MythrilAnvil)
				.Register();
        }
    }
}