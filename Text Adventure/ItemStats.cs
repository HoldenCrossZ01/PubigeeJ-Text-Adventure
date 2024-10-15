namespace Text_Adventure
{
    struct ItemStats
    {
        public enum Item
        {
            nothing,
            stick,
            rock,
            pinecone
        }

        public Item itemType;
        public int itemDurability;
        public int damage;


        public static ItemStats pinecone = new()
        {
            itemType = Item.pinecone,
            itemDurability = 5,
            damage = 1,
        };

        public static ItemStats stick = new()
        {
            itemType = Item.stick,
            itemDurability = 75,
            damage = 40,
        };

        public static ItemStats rock = new()
        {
            itemType = Item.rock,
            itemDurability = 125,
            damage = 25,
        };

    }





}
// I have RUBRIC CATEGORIES:...