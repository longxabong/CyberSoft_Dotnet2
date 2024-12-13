class Product{
    public string maSP;
    public string tenSP;
    public double gia;
    public int tonKho;


    public void nhapThongTin(){
        Console.WriteLine("Mời bạn nhập thông tin:");
        Console.WriteLine("Mã sản phẩm: ");
        maSP = Console.ReadLine();
        Console.WriteLine("Tên sản phẩm: ");
        tenSP =Console.ReadLine();
        Console.WriteLine("Giá sản phẩm: ");
        gia = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Hàng tồn kho:");
        tonKho = Convert.ToInt32(Console.ReadLine());
    }

    public void xuatThongTin(){
        Console.WriteLine("Thông tin sản phẩm");
        Console.WriteLine($"Mã sản phẩm: {maSP}");
        Console.WriteLine($"Tên sản phẩm: {tenSP}");
        Console.WriteLine($"Giá sản phẩm: {gia}");
        Console.WriteLine($"Số lượng tồn kho của sản phẩm: {tonKho}");
    }
}