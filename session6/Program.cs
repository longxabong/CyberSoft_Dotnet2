using System.Net.NetworkInformation;

internal class Program
{
    private static void Main(string[] args)
    {
    #region
    // #region kiểm tra số nguyên tố
    // Console.WriteLine("Mời bạn nhập số: ");
    // int number = Convert.ToInt32(Console.ReadLine());
    // if(Method.checkIsprime(number)){
    //     Console.WriteLine($"Số {number} là số nguyên tố");
    // }
    // else Console.WriteLine($"Số {number} không phải là số nguyên tố");
    // #endregion
    #endregion

    #region in ra tam giác vuông
    // Console.WriteLine("nhập chiều cao tam giác: ");
    // int tg = Convert.ToInt32(Console.ReadLine());
    // Method.tamgiac(tg);
    #endregion
    
    #region Collection trong C#
    //Date Structure
    //List
    List<int> number = new List<int>();

    //define giá trị ban đầu
    List<string> name = new List<string>{"phuong", "duc", "linh", "hung","tri"};
    // Console.WriteLine(name);
    Console.WriteLine("Phần tử thứ 2: " + name[^3]);
    //Lưu ý: writeline chỉ in được giá trị cho những kiểu giữu liệu nguyên thủy như là kiểu int, float, double , string,..
    //Còn kiểu dữ liệu bên collection chỉ in ra địa chỉ vùng nhớ cảu biến đó
    Console.WriteLine(String.Join(", ", name)); 

    Console.WriteLine("Mời bạn nhập số lượng phần tử: ");
    int formatnumber = Convert.ToInt32(Console.ReadLine());
    //Tạo biến chứa danh sách phần từ
    List<int> listNumbers = new List<int>();
    for(int i =0; i<formatnumber;i++){
        //C1: dùng insert
        int formatItem = Convert.ToInt32(Console.ReadLine());
        // listNumbers.Insert(i, formatItem);
        //C2: Dùng Add
        // Add: thêm phần tử vào cuối danh sách
        listNumbers.Add(formatItem);
    }

    for(int i =0;i<listNumbers.Count;i++){
        Console.WriteLine(listNumbers[i]);
    }

    //C2
    foreach(int numbers in listNumbers){
        Console.WriteLine(numbers);
    }
    #endregion
    
    }
    
}