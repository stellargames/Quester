using System;

namespace Quester
{
    internal struct Item
    {
        public RewardType RewardType;
        public ItemCategory Category;
        public ushort ItemId;
        public uint NameRaw;
        public ushort TextRecordId1;
        public ushort TextRecordId2;
        public uint Unknown1;
        public short Index;
        public string Variable;

        public override string ToString()
        {
            string item = $"{Variable}: ";
            if (RewardType == RewardType.Gold || RewardType == RewardType.Unknown)
            {
                item += (Category == ItemCategory.Random) ? "Random gold" : $"{ItemId} - {Category} gold";
            }
            else
            {
                if (!ItemMapper.ItemMap.ContainsKey(Category))
                {
                    Console.Error.WriteLine("{0}: Failed to find item category {1} in item map", Program.Quest.Name, Category);
                    return "ERROR";
                }
                try
                {
                    if (ItemId == 0xffff)
                    {
                        item += $"[{Category}]";
                    }
                    else if (ItemMapper.ItemMap[Category].Count > ItemId)
                    {
                        var name = ItemMapper.ItemMap[Category][ItemId];
                        item += $"{name} [{Category}]";
                    }
                    else
                    {
                        item += $"UNKNOWN ITEM {ItemId} IN CATEGORY {Category}";
                        Console.Error.WriteLine($"{Program.Quest.Name}: no {ItemId} in {Category}");
                    }
                }
                catch (Exception )
                {
                    Console.Error.WriteLine($"{Program.Quest.Name}: no {ItemId} in {Category}");
                    throw;
                }
            }

            if (TextRecordId1 > 0)
                item += $" [{TextRecordId1}]";
            if (TextRecordId2 > 0)
                item += $" [{TextRecordId2}]";

            return item;
        }
    }
}