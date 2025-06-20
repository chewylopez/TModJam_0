using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using TModJam_0.Content.Items;


namespace TModJam_0.Common.GlobalNPCs
{
    public class VanillaNPCLoot : GlobalNPC
    {
        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
            if (NPCID.Sets.Skeletons[npc.type])
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Bone_Marrow_Sample>(), 1));

                // Drop an ExampleResearchPresent in journey mode with 2/7ths base chance, but only in journey mode
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Bone_Marrow_Sample>(), 100));
            }
        }

    }
}
