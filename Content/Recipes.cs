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

            //just for testing stuff

            Recipe test1 = Recipe.Create(ModContent.ItemType<Items.base_drops.Zombie_Blood_Vial>());
            test1.AddIngredient(ItemID.DirtBlock);
            test1.AddTile(TileID.WorkBenches);
            test1.Register();

            Recipe test2 = Recipe.Create(ModContent.ItemType<Items.base_drops.Mutant_Cactus_Spine>());
            test2.AddIngredient(ItemID.DirtBlock);
            test2.AddTile(TileID.WorkBenches);
            test2.Register();

            Recipe test3 = Recipe.Create(ModContent.ItemType<Items.base_drops.Queen_Bee_Poison_Gland>());
            test3.AddIngredient(ItemID.DirtBlock);
            test3.AddTile(TileID.WorkBenches);
            test3.Register();

            Recipe test4 = Recipe.Create(ModContent.ItemType<Items.base_drops.Bone_Marrow_Sample>());
            test4.AddIngredient(ItemID.DirtBlock);
            test4.AddTile(TileID.WorkBenches);
            test4.Register();

            Recipe test5 = Recipe.Create(ModContent.ItemType<Items.base_drops.Writhing_Mass>());
            test5.AddIngredient(ItemID.Wood);
            test5.AddTile(TileID.WorkBenches);
            test5.Register();

        }

    }
}
