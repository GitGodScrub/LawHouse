namespace DataClassLibrary
{
   public class ListItems
    {
        public string ListID { get; set; }
        public string What_type { get; set; }
        public ListItems() { }
        public ListItems(string What_type)
        {
            this.What_type = What_type;
        }
    }
}
