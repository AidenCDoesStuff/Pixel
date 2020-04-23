using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace Pixel.Walls
{
	public class BlackWallTile : ModWall
	{
		public override void SetDefaults()
		{
			Main.wallHouse[Type] = true;
			drop = mod.ItemType("BlackWall");
			AddMapEntry(new Color(0, 0, 0));
		}

		public override void NumDust(int i, int j, bool fail, ref int num)
		{
			num = fail ? 1 : 3;
		}

		public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
		{
			r = 1.0f;
			g = 1.0f;
			b = 1.0f;
		}
	}
}