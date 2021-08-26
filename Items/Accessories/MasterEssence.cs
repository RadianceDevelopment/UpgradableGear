using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class MasterEssence : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Soul Master's Essence");
			Tooltip.SetDefault("The concentrated essence of a great warrior.\nGrants +50% to all damage\nGrants +15% Critical Chance\nReduces Mana Cost by 20%\n+25% Melee Speed\n+8 Minion Slots\nCurrent Tier: X");
		}
		
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 1;
            Item.rare = 10;
			Item.accessory = true;
			Item.expert = true;
			Item.value = Item.sellPrice(copper: 6000); // Should be about 6 gold or so
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.magicDamage+= 0.50f;
			player.meleeDamage+= 0.50f;
			player.rangedDamage+= 0.50f;
			player.minionDamage+= 0.50f;
					
			player.magicCrit+= 15;
			player.meleeCrit+= 15;
			player.rangedCrit+= 15;
						
			player.manaCost-= 0.20f;
			player.meleeSpeed+= 0.25;
			player.maxMinions+= 8;
        }
        public override void AddRecipes()
        {
			CreateRecipe(1)
				.AddIngredient(mod.GetItem("MageEssence_T5"), 1)
				.AddIngredient(mod.GetItem("RangerEssence_T5"), 1)
				.AddIngredient(mod.GetItem("SummonerEssence_T6"), 1)
				.AddIngredient(mod.GetItem("WarriorEssence_T5"), 1)
				.AddIngredient(mod.GetItem("MobSoul"), 250)
				.AddIngredient(ItemID.LunarBar, 5)
				.AddTile(TileID.LunarCraftingStation)
				.Register();
        }
    }
}