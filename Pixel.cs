using Terraria.ModLoader;

namespace Pixel
{
	public class Pixel : Mod
	{
		public Pixel()
		{

		}
        public override void PostSetupContent()
        {
            Mod censusMod = ModLoader.GetMod("Census");
            if(censusMod != null)
            {

                censusMod.Call("TownNPCCondition", NPCType("PixelDealer"), "Have 8 or more NPC's or kill Wall of Flesh.");
            }
        }
    }
}