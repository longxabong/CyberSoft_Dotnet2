using Newtonsoft.Json;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        // #region : Bài 1 Quản lý lớp học

        // // B1: Quản lý lớp học
        // // 1. Lớp học
        // // Tạo lớp Classroom để quản lý lớp học
        // //classId: mã lớp học
        // // className: tên lớp học
        // // danh sách sinh viên trong lớp
        // // 2. Sinh viên
        // // studentId: mã sinh viên
        // // studentName: tên sinh viên
        // // age: tuổi
        // //3. Yêu cầu chức năng
        // // thêm sinh viên vào lớp
        // // hiển thị danh sách sinh viên trong lớp
        // // tìm sinh viên theo mã sinh viên

        // //tạo lớp học
        // Classroom classroom = new Classroom("C02","Dotnet02");
        // // tạo menu quản lý sinh viên
        // // 1. Thêm sinh viên
        // // 2. Hiển thị danh sách sinh viên
        // // 3. tìm kiếm sinh viên theo mã sinh viên
        // // 4. Thoát

        // while(true){
        //     Console.WriteLine("\n-----Classroom Management-----");
        //     Console.WriteLine("1. Add student");
        //     Console.WriteLine("2. Show students");
        //     Console.WriteLine("3. Fine student by student ID");
        //     Console.WriteLine("4. Exit");
        //     Console.WriteLine("Please enter your choice (1-4);");
        //     int choice = Convert.ToInt32(Console.ReadLine());
        //     switch(choice){
        //         case 1:
        //             // thêm sinh viên
        //             Console.WriteLine("Enter student Id:");
        //             string studentId = Console.ReadLine();
        //             Console.WriteLine("Enter student name");
        //             string studentName = Console.ReadLine();
        //             Console.WriteLine("Enter age");
        //             int age = Convert.ToInt32(Console.ReadLine());

        //             Student student = new Student(studentId,studentName,age);
        //             // theem sinh viên vào lớp
        //             classroom.addStudent(student);

        //             // lưu danh sách sinh viên vào json

        //             // chuyển danh sách sinh viên thành json
        //             // var json = JsonConverter.SerializeObject(classroom.Students);
        //             break;
        //         case 2:
        //             // Hiển thị danh sách sinh viên
        //             classroom.showStudents();
        //             break;
        //         case 3:
        //             // Tìm kiếm sinh viên theo mã sinh viên
        //             Console.WriteLine($"Enter student ID to find:");
        //             string id = Console.ReadLine();
        //             if(id == null){
        //                 Console.WriteLine("Student ID is required");

        //             }
        //             classroom.findStudentByStudentId(id);
        //             break;

        //         case 4:
        //             // thoát
        //             return;

        //         default:
        //             Console.WriteLine($"Invalid choice. Please Enter 1-4");
        //             break;
        //     }
        // }
        // #endregion
    
    
        #region Bài 2: Quản lý thư viện
        // 1. Tạo class Book để quản lý sách
        // - bookId: mã sách
        // - bookName: tên sách
        // - author: tác giả
        // - price: giá sách
        // -------------------
        // 2. Tạo class Library để quản lý thư viện
        // - libraryId: mã thư viện
        // - libraryName: tên thư viện
        // - danh sách sách trong thư viện
        // -------------------
        // 3. Yêu cầu chức năng
        // - Thêm sách vào thư viện
        // - Hiển thị danh sách sách trong thư viện
        // - Tìm sách theo mã sách
        // - Thoát
        Library library = new Library("C02","Dotnet02");
        while(true){
            Console.WriteLine("\n-----Book Management-----");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Show Book");
            Console.WriteLine("3. Fine Book by Book ID");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Please enter your choice (1-4);");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch(choice){
                case 1:
                    // thêm sinh viên
                    Console.WriteLine("Enter book Id:");
                    string bookId = Console.ReadLine();
                    Console.WriteLine("Enter Book name");
                    string bookName = Console.ReadLine();
                    Console.WriteLine("Enter author");
                    string author = Console.ReadLine();
                    Console.WriteLine("Enter gia");
                    int gia = Convert.ToInt32(Console.ReadLine());

                    Book book = new Book(bookId,bookName,author,gia);
                    // theem sinh viên vào lớp
                    library.addBook(book);

                    // lưu danh sách sinh viên vào json

                    // chuyển danh sách sinh viên thành json
                    var json = JsonConvert.SerializeObject(library.books);
                    // lưu json vào file
                    File.WriteAllText("books.json", json);

                    Console.WriteLine("Add book successfully");
                    break;
                case 2:
                    // Hiển thị danh sách sinh viên
                    // đọc danh sách sinh viên từ file json
                    var booksJson = File.ReadAllText("books.json");
                    //chuyển json thành danh sách sinh viên
                    library.books = JsonConvert.DeserializeObject<List<Book>>(booksJson);
                    library.showBooks();
                    break;
                case 3:
                    // Tìm kiếm sinh viên theo mã sinh viên
                    Console.WriteLine($"Enter book ID to find:");
                    string id = Console.ReadLine();
                    if(id == null){
                        Console.WriteLine("book ID is required");

                    }
                    library.findBookBybookId(id);
                    break;

                case 4:
                    // thoát
                    return;

                default:
                    Console.WriteLine($"Invalid choice. Please Enter 1-4");
                    break;
            }
        }

        #endregion    
    }
}