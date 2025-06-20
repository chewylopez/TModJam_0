using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TModJam_0.Content
{
    internal class Recipes : ModSystem
    {

        public override void AddRecipes()
        {
            Recipe test1 = Recipe.Create(ModContent.ItemType<Content.Items.Zombie_Blood_Vial>());
            test1.AddIngredient(ItemID.DirtBlock);
            test1.AddTile(TileID.WorkBenches);
            test1.Register();

            Recipe test2 = Recipe.Create(ModContent.ItemType<Content.Items.Mutant_Cactus_Spine>());
            test2.AddIngredient(ItemID.DirtBlock);
            test2.AddTile(TileID.WorkBenches);
            test2.Register();

            Recipe test3 = Recipe.Create(ModContent.ItemType<Content.Items.Queen_Bee_Poison_Gland>());
            test3.AddIngredient(ItemID.DirtBlock);
            test3.AddTile(TileID.WorkBenches);
            test3.Register();

            Recipe test4 = Recipe.Create(ModContent.ItemType<Content.Items.Queen_Bee_Poison_Gland>());
            test4.AddIngredient(ItemID.DirtBlock);
            test4.AddTile(TileID.WorkBenches);
            test4.Register();

        }

    }
}
