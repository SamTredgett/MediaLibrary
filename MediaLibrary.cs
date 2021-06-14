namespace MediaLibrary{

    class MediaLibrary{
        public MediaType[] _items;
        public int NumberOfItems => _items.Length;
        public MediaLibrary(MediaType[] items){
            _items = items;
        }

        public MediaType GetItemAt(int index){
            return (index>this._items.Length) ? null : this._items[index];           
        }
    }
}
