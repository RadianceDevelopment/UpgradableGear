using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SoulSang.Items
{
	public class SoulFish : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Soul Feaster");
			Tooltip.SetDefault("A fish that feasts on monster souls. And sometimes human ones\nDedicated to Xorger128");
		}

		public override void SetDefaults() {
			Item.questItem = true;
			Item.maxStack = 1;
			Item.width = 25;
			Item.height = 25;
			Item.uniqueStack = true;
			Item.rare = ItemRarityID.Quest;
		}

		public override bool IsQuestFish() {
			return true;
		}

		public override bool IsAnglerQuestAvailable() {
			return Main.hardMode;
		}

		public override void AnglerQuestChat(ref string description, ref string catchLocation) {
			description = "I've heard stories of a fish made out of souls! That sounds cool, so go get me one!";
			catchLocation = "Caught anywhere";
		}
	}
}
// Dedicated to Xorger128, who for some reason loves fishing (also gave me some Item ideas)
// He's still salty about the 1.4 re-balancing, lol