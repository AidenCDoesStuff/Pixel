using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Pixel.Items
{
    public class PixelPet : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName and Tooltip are automatically set from the .lang files, but below is how it is done normally.
            DisplayName.SetDefault("Pixel Pet");
            Tooltip.SetDefault("Your very own pixel pet!");
        }

        public override void SetDefaults()
        {
            item.shoot = mod.ProjectileType("PixelPetProjectile");
            item.buffType = mod.BuffType("PixelPetBuff");
            item.damage = 0;
            item.useStyle = 1;
            item.width = 26;
            item.height = 26;
            item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/PixelPetSound");
            item.useAnimation = 20;
            item.useTime = 20;
            item.rare = 8;
            item.noMelee = true;
            item.value = Item.sellPrice(0, 1, 00, 0);
        }

        public override void UseStyle(Player player)
        {
            if (player.whoAmI == Main.myPlayer && player.itemTime == 0)
            {
                player.AddBuff(item.buffType, 3600, true);
            }
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Red"), 100);
            recipe.AddIngredient(mod.ItemType("Lime"), 100);
            recipe.AddIngredient(mod.ItemType("Blue"), 100);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}