using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UpgradableGear.Items.Weapons
{
	public class SoulSword_Ichor : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Ichor-Coated Soul Sword");
			Tooltip.SetDefault("You've transformed the sword into a more specialized one.\nDoes less damage, but reduces enemy defense by 20\nCurrent Tier: Ichor-X");
	    }

		public override void SetDefaults() 
		{
			item.damage = 200;
			item.knockBack = 8;
			item.crit = 14;
			item.melee = true;
			item.width = 70;
			item.height = 85;
			item.useTime = 5;
			item.useAnimation = 15;
			item.useStyle = 1;
			item.rare = 11;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.value = Item.sellPrice(2, 50, 0, 0);
			item.expert = true;
		}

		public override void AddRecipes()
		{
			
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("SoulSword_T10"), 1);
			recipe.AddIngredient(ItemID.FlaskofIchor, 1);
			recipe.AddIngredient(ItemID.Ichor, 3);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 150);
			recipe.AddTile(TileID.LunarCraftingStation );
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		
	    public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
		{
			// I assume you can make healingAmount any number or formula?
			int healingAmount = damage/5;
			player.statLife +=healingAmount;
			player.HealEffect(healingAmount, true);
			
			if(Main.rand.NextBool(1)){
			target.AddBuff(BuffID.Ichor, 300);
		}
		}
	}
}
// Shoutout to absoluteAquarian#5189 on the TML Discord for fixing the debuff application not working
// Item.crit adds to the base 4%

// Add projectile