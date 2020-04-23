using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Pixel.NPCs
{
	// [AutoloadHead] and npc.townNPC are extremely important and absolutely both necessary for any Town NPC to work at all.
	[AutoloadHead]
	public class PixelDealer : ModNPC
	{
		public override string Texture { 
		    get { return "Pixel/NPCs/PixelDealer"; }
        }

		public override string[] AltTextures
		{
			get { return new[] { "Pixel/NPCs/PixelDealer_Alt_1" }; }
		}

		public override bool Autoload(ref string name)
		{
			name = "PixelDealer";
			return mod.Properties.Autoload;
		}

		public override void SetStaticDefaults()
		{
			Main.npcFrameCount[npc.type] = 26;
			NPCID.Sets.ExtraFramesCount[npc.type] = 9;
			NPCID.Sets.AttackFrameCount[npc.type] = 4;
			NPCID.Sets.DangerDetectRange[npc.type] = 700;
			NPCID.Sets.AttackType[npc.type] = 0;
			NPCID.Sets.AttackTime[npc.type] = 90;
			NPCID.Sets.AttackAverageChance[npc.type] = 30;
			NPCID.Sets.HatOffsetY[npc.type] = 4;
		}

		public override void SetDefaults()
		{
			npc.townNPC = true;
			npc.friendly = true;
			npc.width = 20;
			npc.height = 40;
			npc.aiStyle = 7;
			npc.damage = 10;
			npc.defense = 15;
			npc.lifeMax = 250;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.knockBackResist = 0.5f;
			animationType = NPCID.Guide;
		}
        
        public override bool CanTownNPCSpawn(int numTownNPCs, int money)
        {
            if (numTownNPCs >= 8)
                return true;
            else if (Main.hardMode == true)
                return true;
            else
                return false;
        }

        public override string TownNPCName()
		{
			switch (WorldGen.genRand.Next(14))
			{
				case 0:
					return "Jim";
				case 1:
					return "Victor";
				case 2:
					return "Jamison";
                case 3:
                    return "Adam";
                case 4:
                    return "Angelo";
                case 5:
                    return "Morgan";
                case 6:
                    return "Erin";
                case 7:
                    return "Nick";
                case 8:
                    return "Eric";
                case 9:
                    return "Edmund";
                case 10:
                    return "Joe";
                case 11:
                    return "Lucas";
                case 12:
                    return "Pedro";
                default:
					return "Paul";
			}
		}

		public override string GetChat()
		{
			int Painter = NPC.FindFirstNPC(NPCID.Painter);
			if (Painter >= 0 && Main.rand.Next(4) == 0)
			{
				return "Why does " + Main.npc[Painter].GivenName + " think he's so much better than me?";
			}
			switch (Main.rand.Next(6))
			{
				case 0:
					return "Honestly these pixels are way overpriced.";
				case 1:
					return "I can't see through these shades so make sure I sell you the right blocks.";
                case 2:
                    return "I wish I had my own little pixel pet. Don't you?";
                case 3:
                    return "Olive looks as bad as it tastes.";
                case 4:
                    return "Lime walls are really good for green screens.";
                default:
					return "Have you heard of Piskel?";
			}
		}

		public override void SetChatButtons(ref string button, ref string button2)
		{
			button = Language.GetTextValue("LegacyInterface.28");
		}

		public override void OnChatButtonClicked(bool firstButton, ref bool shop)
		{
			if (firstButton)
			{
				shop = true;
			}
			else
			{
			}
		}

		public override void SetupShop(Chest shop, ref int nextSlot)
		{
			shop.item[nextSlot].SetDefaults(mod.ItemType("Red"));
			nextSlot++;
            shop.item[nextSlot].SetDefaults(mod.ItemType("Maroon"));
            nextSlot++;
            shop.item[nextSlot].SetDefaults(mod.ItemType("Orange"));
			nextSlot++;
			shop.item[nextSlot].SetDefaults(mod.ItemType("Yellow"));
			nextSlot++;
            shop.item[nextSlot].SetDefaults(mod.ItemType("Olive"));
            nextSlot++;
            shop.item[nextSlot].SetDefaults(mod.ItemType("Lime"));
			nextSlot++;
			shop.item[nextSlot].SetDefaults(mod.ItemType("Green"));
			nextSlot++;
			shop.item[nextSlot].SetDefaults(mod.ItemType("Cyan"));
			nextSlot++;
            shop.item[nextSlot].SetDefaults(mod.ItemType("Teal"));
            nextSlot++;
            shop.item[nextSlot].SetDefaults(mod.ItemType("Blue"));
            nextSlot++;
            shop.item[nextSlot].SetDefaults(mod.ItemType("Navy"));
            nextSlot++;
            shop.item[nextSlot].SetDefaults(mod.ItemType("Purple"));
            nextSlot++;
            shop.item[nextSlot].SetDefaults(mod.ItemType("Magenta"));
            nextSlot++;
            shop.item[nextSlot].SetDefaults(mod.ItemType("Pink"));
            nextSlot++;
            shop.item[nextSlot].SetDefaults(mod.ItemType("White"));
            nextSlot++;
            shop.item[nextSlot].SetDefaults(mod.ItemType("Silver"));
            nextSlot++;
            shop.item[nextSlot].SetDefaults(mod.ItemType("Gray"));
            nextSlot++;
            shop.item[nextSlot].SetDefaults(mod.ItemType("Black"));
            nextSlot++;
            //if(Main.moonPhase == 8)
            //{
                //shop.item[nextSlot].SetDefaults(mod.ItemType("Pixel Pet"));
                //nextSlot++;
            //}
        }

		//public override void NPCLoot()
		//{
			//Item.NewItem(npc.getRect(), mod.ItemType<Items.Armor.ExampleCostume>());
		//}

		public override void TownNPCAttackStrength(ref int damage, ref float knockback)
		{
			damage = 20;
			knockback = 4f;
		}

		public override void TownNPCAttackCooldown(ref int cooldown, ref int randExtraCooldown)
		{
			cooldown = 30;
			randExtraCooldown = 30;
		}

		public override void TownNPCAttackProj(ref int projType, ref int attackDelay)
		{
			projType = mod.ProjectileType("SparklingBall");
			attackDelay = 1;
		}

        public override void TownNPCAttackProjSpeed(ref float multiplier, ref float gravityCorrection, ref float randomOffset)
        {
            multiplier = 12f;
            randomOffset = 2f;
        }
    }
}