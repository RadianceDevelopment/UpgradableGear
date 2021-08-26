using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Accessories
{
	public class WarriorEssence_T5 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("True Soul Warrior's Essence");
			Tooltip.SetDefault("The Essence twists and convulses, then reveals its true form\nGrants +25% melee damage and +20% melee speed\nBoosts melee critical chance by 10%\nCurrent Tier: V");
		}
		
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 1;
            Item.rare = 9;
			Item.accessory = true;
			Item.value = Item.sellPrice(gold: 1);
        }
		
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			Player.GetDamage(DamageClass.Melee) += 0.25f;
			player.meleeSpeed+= 0.20f;
			player.meleeCrit+= 10;
        }
		
        public override void AddRecipes()
        {
			CreateRecipe(1)
				.AddIngredient(mod.GetItem("WarriorEssence_T4"), 1)
				.AddIngredient(mod.GetItem("MobSoul"), 25)
				.AddIngredient(ItemID.FragmentSolar, 5)
				.AddTile(TileID.LunarCraftingStation)
				.Register();
        }
    }
}