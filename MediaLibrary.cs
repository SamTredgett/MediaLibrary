using System;
namespace MediaLibrary{

    class MediaLibrary{
        public MediaType[] _items;
        public int NumberOfItems => _items.Length;
        public MediaLibrary(MediaType[] items){
            _items = items;
        }
        public void DisplayItems()
        {
            for(int i = 0; i<_items.Length; i++)
            {
                DisplayItem(_items[i]);
            }
        }
         public static void DisplayItem(MediaType item){
            if (item == null) {
                return;
            }
            else{
                    if(item is Book ){
                        Console.WriteLine(((Book)item).DisplayText);
                    }
                    else if(item is Film){
                        Console.WriteLine(((Film)item).DisplayText);                    
                    }
                    else if(item is Song){
                        Console.WriteLine(((Song)item).DisplayText);
                    }
                    else{
                        throw new Exception("Unexpected Media subtype encountered.");
                    } 
            
         }}

        public MediaType GetItemAt(int index){
            return (index>this._items.Length) ? null : this._items[index];           
        }
    }
}
