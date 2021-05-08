namespace Items
{
    public class Item
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public int Img { get; set; }
        public int Count { get; set; }

        public Item(string id, string name, int img, int count)
        {
            ID = id;
            Name = name;
            Img = img;
            Count = count;
        }

        public Item()
        {
            
        }
    }
}