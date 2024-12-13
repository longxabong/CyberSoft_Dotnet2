class Library{
    public string libraryId;
    public string libraryName;
     public List<Book> books;

     public Library(string libraryId, string libraryName){
        this.libraryId = libraryId;
        this.libraryName = libraryName;
        this.books = new List<Book>();

     }

     // phương thức thêm sách
     public void addBook(Book book){
        books.Add(book);
        Console.WriteLine($"Book {book.bookName} added to Library {libraryName}");
     }
     public void showBooks(){
        Console.WriteLine($"\n ----Book in Library {libraryName}");
        foreach (Book book in books)
        {
            book.displayInfo();
        }
    }

    public void findBookBybookId(string bookId){
        foreach (Book book in books){
            if(book.bookId == bookId){
                book.displayInfo();
                return;
            }
        }
        // trong trường hợp duyệt hết danh sách mà không có sinh viên nào
        Console.WriteLine($"book with ID {bookId} not found in library {libraryName}");
    }
        
}