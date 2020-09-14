using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Weapons
{
	public class SoulSword_Ichor : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Ichor-Infused Soul Sword");
			Tooltip.SetDefault("You've transformed the sword into a more specialized one.\nInflicts Ichor for 3 seconds 50% of the time");
	    }

		public override void SetDefaults() 
		{
			item.damage = 30;
			item.knockBack = 5;
			item.crit = 6;
			// Remember that Item.crit adds to the base 4%
			item.melee = true;
			item.width = 70;
			item.height = 85;
			item.useTime = 5;
			item.useAnimation = 15;
			item.useStyle = 1;
			item.rare = 4;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.value = Item.sellPrice(2, 50, 0, 0);
			item.expert = true;
		}

		public override void AddRecipes()
		{
			
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("SoulSword_T2"), 1);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 150);
			recipe.AddIngredient(ItemID.Ichor, 10);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		
	    public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
		{
			// Remember, 60 ticks = 1 second
			if(Main.rand.NextBool(2)){
			target.AddBuff(BuffID.Ichor, 180);
			// 3 Seconds^
		  }
		}
	}
}
// Shoutout to absoluteAquarian#5189 on the TML Discord for fixing the debuff application not working