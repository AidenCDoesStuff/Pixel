using Terraria.ModLoader;

namespace Pixel.Items.Placeable
{
	public class BlueWall : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Blue Wall"); 
			Tooltip.SetDefault("");
		}

		public override void SetDefaults()
		{
			item.width = 16;
			item.height = 16;
            item.value = 25;
			item.maxStack = 999;
            item.useTime = 3;
            item.useAnimation = 15;
            item.useStyle = 1;
            item.useTurn = true;
			item.autoReuse = true;
			item.consumable = true;
			item.createWall = mod.WallType("BlueWallTile");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "Blue");
			recipe.SetResult(this, 4);
			recipe.AddRecipe();
		}
	}
}