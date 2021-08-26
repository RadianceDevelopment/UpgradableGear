using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class MageEssence_T1 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Soul Mage's Essence");
			Tooltip.SetDefault("Monster Souls that are forced to obey your magical commands\nGrants +5% Magic Damage\nCurrent Tier: I");
		}
		
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 0;
            Item.rare = 0;
			Item.accessory = true;
			Item.value = Item.sellPrice(copper: 0);
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.magicDamage+= 0.05f;
        }
        public override void AddRecipes()
        {
			CreateRecipe(1)
				.AddIngredient(mod.GetItem("MobSoul"), 10)
				.AddTile(TileID.WorkBenches)
				.Register();
        }
    }
}