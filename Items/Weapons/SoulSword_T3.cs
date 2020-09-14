using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items.Weapons
{
	public class SoulSword_T3 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Soul Sword III");
			Tooltip.SetDefault("The sword has reached its zenith");
		}
		// Be sure to make this shoot the ghost orb!
		public override void SetDefaults() 
		{
			item.damage = 200;
			item.knockBack = 10;
			item.melee = true;
			item.autoReuse = true;
			item.width = 30;
			item.height = 30;
			item.scale = 0.73f;
			item.useTime = 5;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.rare = 11;
			item.UseSound = SoundID.Item1;
			item.value = Item.sellPrice(0, 5, 0, 0);
			item.expert = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("SoulSword_Cursed"), 1);
			recipe.AddIngredient(mod.GetItem("SoulSword_Ichor"), 1);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 380);
			recipe.AddIngredient(ItemID.LunarBar, 4);
			//recipe.AddTile(TileID.SoulInfuser);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		
		 public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
		{
			// Remember, 60 ticks = 1 second
			if(Main.rand.NextBool(2)){
			target.AddBuff(BuffID.Ichor, 300);
			// 5 Seconds^
		  }
			// Remember, 60 ticks = 1 second
			if(Main.rand.NextBool(2)){
			target.AddBuff(BuffID.Ichor, 300);
			// 5 Seconds^
		  }
		}
	}
}