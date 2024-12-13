class Rectangle {
    public int lengTh;
    public int wiDth;


    public void nhapThongTin(){
        Console.WriteLine("Mời bạn nhập chiều dài:");
        lengTh= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Mời bạn nhập chiều rộng:");
        wiDth= Convert.ToInt32(Console.ReadLine());
    }

    public void Tinh(){
        Console.WriteLine($"Chu vi của hình chữ nhật: {(wiDth+lengTh)*2}");
        Console.WriteLine($"Diện tích hình chữ nhật là: {lengTh*wiDth}");
    }
}