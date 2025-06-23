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
using TModJam_0.Content.Items.accessories;


namespace TModJam_0.Common.GlobalNPCs
{
    public class VanillaNPCLoot : GlobalNPC
    {
        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {

            Player player = Main.player[npc.lastInteraction];
            int ID = ModContent.ItemType<Potion_Backpack>();

            if (NPCID.Sets.Skeletons[npc.type])
            {
                if (IsWearingAccessory(player, ID)) {
                    npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Bone_Marrow_Sample>(), 25));
                }
                else
                {
                    npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Bone_Marrow_Sample>(), 50));
                }
                
            }



        }

        public static bool IsWearingAccessory(Player player, int accessoryItemID)
        {
            // Accessory slots are in armor[3] to armor[8] (vanilla)
            // armor[9] to armor[13] are vanity accessories (non-functional)
            for (int i = 3; i < 10; i++) // Include up to armor[9] for modded slots
            {
                if (player.armor[i] != null && !player.armor[i].IsAir && player.armor[i].type == accessoryItemID)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
