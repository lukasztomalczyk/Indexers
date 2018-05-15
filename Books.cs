namespace Indexers
{
    class Books
    {
        private readonly string[] _listOfBooks = new string[10];

        public Books()
        {
            for (int i = 0; i < _listOfBooks.Length; i++)
            {
                _listOfBooks[i] = $"this is {i} item from array";
            }
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < _listOfBooks.Length)
                {
                    return _listOfBooks[index];
                }

                return null;
            }
            set => _listOfBooks[index] = value;
        }

        public int this[string name]
        {
            get
            {
                int index = 0;
                
                while (index < _listOfBooks.Length)
                {
                    if (_listOfBooks[index] == name) return index;
                    index++;
                }

                return 0;
            }
        }
    }
}