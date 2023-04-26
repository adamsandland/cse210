// See https://aka.ms/new-console-template for more information
List<book> book_list = new List<book>();


book mistborn = new book("Mistborn", "Brandon Sanderson");
book book_of_mormon = new book("Book of Mormon", "Moroni");

mistborn.Display();
book_of_mormon.Display();



/*void make_booklist(string name, string author){
    book new_book = new book(name, author);
    book_list.Add(new_book);
}*/