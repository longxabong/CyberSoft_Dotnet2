class Book{
    public string bookId;
    public string bookName;
    public string author;
    public int gia;

    public Book(string bookId, string bookName, string author, int gia){
        this.bookId = bookId;
        this.bookName = bookName;
        this.author = author;
        this.gia = gia;
    }

    public void displayInfo(){
        Console.WriteLine($"ID: {bookId}, Book name: {bookName}, author: {author}, Gia tien: {gia}");
    }
}