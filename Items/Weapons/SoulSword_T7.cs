using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Weapons
{
	public class SoulSword_T7 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Soul Sword VII");
			Tooltip.SetDefault("The sword lights up with blue fire...\nHeals equal to the damage dealt divided by 9\nApplies Frostburn 50% of the time\nLaunches a ghostly projectile when swung (Still WIP!)\nCurrent Tier: VII");
	    }

		public override void SetDefaults() 
		{
			item.damage = 55;
			item.knockBack = 7;
			item.crit = 6;
			item.melee = true;
			item.width = 48;
			item.height = 55;
			item.useTime = 21;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.rare = 5;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.value = Item.sellPrice(0, 3, 0, 0);
		}

		public override void AddRecipes()
		{
			
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("SoulSword_T6"), 1);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 60);
			recipe.AddIngredient(ItemID.AdamantiteBar, 5);
			recipe.AddIngredient(ItemID.FrostCore, 1);
			//recipe.AddTile(TileType<SoulForge>());
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("SoulSword_T6"), 1);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 60);
			recipe.AddIngredient(ItemID.TitaniumBar, 5);
			recipe.AddIngredient(ItemID.FrostCore, 1);
			//recipe.AddTile(TileType<SoulForge>());
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		
	    public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
		{
			// I assume you can make healingAmount any number or formula?
			int healingAmount = damage/9;
			player.statLife +=healingAmount;
			player.HealEffect(healingAmount, true);
			
			if(Main.rand.NextBool(2)){
			target.AddBuff(BuffID.Frostburn, 180);
		}
	  }
	}
}
// Shoutout to absoluteAquarian#5189 on the TML Discord for fixing the debuff application not working
// Item.crit adds to the base 4%

// Add projectile