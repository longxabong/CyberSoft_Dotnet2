internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        #region function trong List của Collection
        // //Khởi tạo danh sách
        // List<int> numbers = new List<int>();
        // //nhập n từ bàn phím với n là số lượng phần tử của mảng
        // string? n = Console.ReadLine();
        // int format = Convert.ToInt32(n);
        // for(int i =0;i<format;i++){
        //     Console.WriteLine($"Mời bạn nhập số thứ{i+1}");
        //     int number = Convert.ToInt32(Console.ReadLine());
        //     numbers.Add(number);
        // }
        // Console.WriteLine("Danh sách phần tử đã nhập là: ");
        // foreach (int item in numbers)
        // {
        //     Console.WriteLine(item);
        // }
        // Console.Write(String.Join("," , numbers));
        #endregion
        #region 

        // // Dùng function để sắp xếp phần tử của mảng
        // numbers.Sort();
        // Console.WriteLine("Danh sách phần tử đã sắp xếp");
        // Console.Write(String.Join(", ", numbers));

        // // Dùng function Reverse()
        // numbers.Reverse();
        // Console.WriteLine("Danh sách phần tử sau khi dùng hàm Reverse");
        // Console.Write(String.Join(", ", numbers));

        #endregion


        // #region Bài 1: Tính tổng các phần từ lớn hơn 50
        // List<int> IstNumber = new List<int>{20,81,97,63,72,11,20,15,33,15,41,20};
        // int sum = Bai1.tinhTongSoLon50(IstNumber);
        // Console.WriteLine($"Tổng của mảng: {sum}");
        // #endregion

        // #region Bài 2: Tìm số lớn nhất của mảng
        // int maxs = Bai1.maxList(IstNumber);
        // Console.WriteLine($"Số lớn nhất của mảng: {maxs}");
        // #endregion

        // #region Bài 3: Tìm chuỗi bắt đầu bằng chữ 'm'
        // List<string> lstString = new List<string>{"apple","banana", "orange","kiwi","mango","pineapple", "grape", "melon"};
        // List<string> result = Bai3.findAllStartM(lstString);
        // Console.WriteLine("danh sach nhung phan tu bat dau ban m");
        // foreach(string str in result){
        //     Console.WriteLine(str);
        // }
        // #endregion

        // #region 
        // List<int> istNumber = new List<int> {1,1,2,2,2,3,4,4,5};
        // List<int> results = Bai4.istNumber(istNumber);
        // Console.WriteLine("Danh sach cac phan tu khong trung nhau");
        // foreach(int a in results){
        //     Console.WriteLine(a);
        // }
        // #endregion



        #region Tìm hiểu về dictionary trong Colllection
        Dictionary<string, string> dic = new Dictionary<string, string>();
        // them kew-value vao dic
        dic.Add("alice", "ted");
        dic["Do"] = "Nam Trung";


        //Duyệt dic
        foreach (KeyValuePair<string, string> pointer in dic)
        {
            //pointer: key-value
            Console.WriteLine($"Họ: {pointer.Key}, Tên: {pointer.Value}");
        }

        // Chỉ duyệt mỗi key ỏ value=> y chang như bên list
        //Chỉ duyệt key
        foreach (string str in dic.Keys)
        {
            Console.WriteLine(str);
        }
        for (int i = 0; i < dic.Keys.Count; i++)
        {
            Console.WriteLine(dic.Keys.ElementAt(i));
        }




        //update value cho dic
        dic["alice"] = "johnson";
        Console.WriteLine("dic sau khi update");
        foreach (KeyValuePair<string, string> pointer in dic)
        {
            Console.WriteLine($"Họ:{pointer.Key}, tên: {pointer.Value}");
        }



        // xóa key-value trong dic
        dic.Remove("alice");
        Console.WriteLine("dic sau khi remove");
        foreach (KeyValuePair<string, string> pointer in dic)
        {
            Console.WriteLine($"Họ:{pointer.Key}, tên: {pointer.Value}");
        }
        #endregion





    }
}