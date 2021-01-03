using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items
{
	public class MobSoul : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Monster Soul");
			Tooltip.SetDefault("The concentrated form of a monsters' very will and fabric of their being\nCan be used to create various powerful relics.\nBut be warned, this strays into Necromantic territory.");
		}

		public override void SetDefaults() 
		{
			item.width = 40;
			item.height = 40;
			item.rare = 0;
			item.maxStack = 999;
			item.value = Item.sellPrice(0, 0, 0, 1);
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Gel, 2);
			recipe.AddTile(TileID.WorkBenches);
			//recipe.AddTile(TileType<SoulInfuser>());
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Lens, 1);
			recipe.AddTile(TileID.WorkBenches);
			//recipe.AddTile(TileType<SoulInfuser>());
			recipe.SetResult(this, 2);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BlackLens, 1);
			recipe.AddTile(TileID.WorkBenches);
			//recipe.AddTile(TileType<SoulInfuser>());
			recipe.SetResult(this, 15);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Feather, 1);
			recipe.AddTile(TileID.WorkBenches);
			//recipe.AddTile(TileType<SoulInfuser>());
			recipe.SetResult(this, 5);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.AntlionMandible, 1);
			recipe.AddTile(TileID.WorkBenches);
			//recipe.AddTile(TileType<SoulInfuser>());
			recipe.SetResult(this, 7);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.WormTooth, 1);
			recipe.AddTile(TileID.WorkBenches);
			//recipe.AddTile(TileType<SoulInfuser>());
			recipe.SetResult(this, 3);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.RottenChunk, 1);
			recipe.AddTile(TileID.WorkBenches);
			//recipe.AddTile(TileType<SoulInfuser>());
			recipe.SetResult(this, 4);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Vertebrae, 1);
			recipe.AddTile(TileID.WorkBenches);
			//recipe.AddTile(TileType<SoulInfuser>());
			recipe.SetResult(this, 4);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Bone, 3);
			recipe.AddTile(TileID.BoneWelder);
			//recipe.AddTile(TileType<SoulInfuser>());
			recipe.SetResult(this, 5);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Stinger, 1);
			recipe.AddTile(TileID.WorkBenches);
			//recipe.AddTile(TileType<SoulInfuser>());
			recipe.SetResult(this, 6);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ShadowScale, 1);
			recipe.AddTile(TileID.Anvils);
			//recipe.AddTile(TileType<SoulInfuser>());
			recipe.SetResult(this, 7);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.TissueSample, 1);
			recipe.AddTile(TileID.Anvils);
			//recipe.AddTile(TileType<SoulInfuser>());
			recipe.SetResult(this, 7);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PinkGel, 2);
			recipe.AddTile(TileID.WorkBenches);
			//recipe.AddTile(TileType<SoulInfuser>());
			recipe.SetResult(this, 8);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.TatteredCloth, 1);
			recipe.AddTile(TileID.WorkBenches);
			//recipe.AddTile(TileType<SoulInfuser>());
			recipe.SetResult(this, 20);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Ectoplasm, 1);
			recipe.AddTile(TileID.MythrilAnvil);
			//recipe.AddTile(TileType<SoulInfuser>());
			recipe.SetResult(this, 12);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DarkShard, 1);
			recipe.AddTile(TileID.MythrilAnvil);
			//recipe.AddTile(TileType<SoulInfuser>());
			recipe.SetResult(this, 25);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LightShard, 1);
			recipe.AddTile(TileID.MythrilAnvil);
			//recipe.AddTile(TileType<SoulInfuser>());
			recipe.SetResult(this, 25);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BeetleHusk, 1);
			// Should be Lihzahrd Furnace
			recipe.AddTile(303);
			//recipe.AddTile(TileType<SoulInfuser>());
			recipe.SetResult(this, 15);
			recipe.AddRecipe();
			/*
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.WhoopieCushion, 1);
			recipe.AddTile(TileID.Anvils);
			//recipe.AddTile(TileType<SoulInfuser>());
			recipe.SetResult(this, 50);
			recipe.AddRecipe();
			*/
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ZombieArm, 1);
			recipe.AddTile(TileID.Anvils);
			//recipe.AddTile(TileType<SoulInfuser>());
			recipe.SetResult(this, 50);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LizardEgg, 1);
			// Lihzahrd Furnace
			recipe.AddTile(303);
			//recipe.AddTile(TileType<SoulInfuser>());
			recipe.SetResult(this, 75);
			recipe.AddRecipe();
		}
	}
}