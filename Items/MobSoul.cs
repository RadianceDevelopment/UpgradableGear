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
			Item.width = 20;
			Item.height = 20;
			Item.rare = 0;
			Item.maxStack = 999;
			Item.value = Item.buyPrice(copper: 0);
		}

		public override void AddRecipes() 
		{
			CreateRecipe(1)
				.AddIngredient(ItemID.Gel, 2)
				.AddTile(TileID.WorkBenches)
				.Register();
			
			resultItem.CreateRecipe(2)
				.AddIngredient(ItemID.Lens, 1)
				.AddTile(TileID.WorkBenches)
				.Register();
			
			resultItem.CreateRecipe(15)
				.AddIngredient(ItemID.BlackLens, 1)
				.AddTile(TileID.WorkBenches)
				.Register();
			
			resultItem.CreateRecipe(5)
				.AddIngredient(ItemID.Feather, 1)
				.AddTile(TileID.WorkBenches)
				.Register();
			
			resultItem.CreateRecipe(7)
				.AddIngredient(ItemID.AntlionMandible, 1)
				.AddTile(TileID.WorkBenches)
				.Register();
			
			resultItem.CreateRecipe(3)
				.AddIngredient(ItemID.WormTooth, 1)
				.AddTile(TileID.WorkBenches)
				.Register();
			
			resultItem.CreateRecipe(4)
				.AddIngredient(ItemID.RottenChunk, 1)
				.AddTile(TileID.WorkBenches)
				.Register();
			
			resultItem.CreateRecipe(4)
				.AddIngredient(ItemID.Vertebrae, 1)
				.AddTile(TileID.WorkBenches)
				.Register();
			
			resultItem.CreateRecipe(5)
				.AddIngredient(ItemID.Bone, 3)
				.AddTile(TileID.BoneWelder)
				.Register();
			
			resultItem.CreateRecipe(6)
				.AddIngredient(ItemID.Stinger, 1)
				.AddTile(TileID.WorkBenches)
				.Register();
			
			resultItem.CreateRecipe(7)
				.AddIngredient(ItemID.ShadowScale, 1)
				.AddTile(TileID.Anvils)
				.Register();
			
			resultItem.CreateRecipe(7)
				.AddIngredient(ItemID.TissueSample, 1)
				.AddTile(TileID.Anvils)
				.Register();
			
			resultItem.CreateRecipe(8)
				.AddIngredient(ItemID.PinkGel, 2)
				.AddTile(TileID.WorkBenches)
				.Register();
			// Not quite sure how souls are in the cloth, but oh well
			resultItem.CreateRecipe(12)
				.AddIngredient(ItemID.TatteredCloth, 1)
				.AddTile(TileID.WorkBenches)
				.Register();
			
			resultItem.CreateRecipe(20)
				.AddIngredient(ItemID.Ectoplasm, 1)
				.AddTile(TileID.MythrilAnvil)
				.Register();
			
			resultItem.CreateRecipe(25)
				.AddIngredient(ItemID.DarkShard, 1)
				.AddTile(TileID.MythrilAnvil)
				.Register();
			
			resultItem.CreateRecipe(25)
				.AddIngredient(ItemID.LightShard, 1)
				.AddTile(TileID.MythrilAnvil)
				.Register();
			
			resultItem.CreateRecipe(15)
				.AddIngredient(ItemID.BeetleHusk, 1)
				// Lihzahrd Furnace
				.AddTile(303)
				.Register();
				
			resultItem.CreateRecipe(50)
				.AddIngredient(ItemID.ZombieArm, 1)
				.AddTile(TileID.Anvils)
				.Register();
			
			resultItem.CreateRecipe(75)
				.AddIngredient(ItemID.LizardEgg, 1)
				// Lihzahrd Furnace
				.AddTile(303)
				.Register();
		}
	}
}