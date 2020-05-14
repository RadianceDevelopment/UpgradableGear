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
			Tooltip.SetDefault("A fish that feasts on monster souls\nAnd sometimes human ones\nDedicated to Xorger128");
		}

		public override void SetDefaults() {
			item.questItem = true;
			item.maxStack = 1;
			item.width = 25;
			item.height = 25;
			item.uniqueStack = true;
			item.rare = ItemRarityID.Quest;
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
// Dedicated to Xorger128, who for some reason loves fishing (also gave me some item ideas)