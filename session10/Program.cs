internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        // 4 tính chất trong OOP
        // Tính kế thừa: class con kế thừa(sở hữu) các thuộc tính(biến) và Phương thức (hàm)
        // của class cha
        
    
        // tính đóng gói
        //tính trừu tượng
        // tính đa hình


        //BT mẫu: Trong công ty có 3 đối tượng: Nhân viên, trưởng nhóm, quản lý.
        //Lập trình quản lý nhân sự trong công ty   
        // Nhân viên: mã nhân viên, tên, ngày sinh, giới tính, tuổi, lương
        // tính lương: nhân viên = 1000
        // trưởng nhóm: mã nhân viên, tên, ngày sinh, giới tính, tuổi, lương, mã quản lý nhóm
        // tính lương: trưởng nhóm = 1000 + hệ số *1000;
        // quản lý: mã nhân viên, tên, ngày sinh, giới tính, tuổi, lương, mã quản lý nhóm, thư ký
        // tính lương: quản lý = 1000 + hệ số*1000 + 500;
        TruongNhom truongNhom = new TruongNhom();
        Console.WriteLine($"Lương trưởng nhóm: {truongNhom.tinhLuong()}");
        // truongNhom.HoTen ="Nguyễn Văn Tèo";
        
        // truongNhom.MaNV ="NV001";
        // Console.WriteLine($"Tên trưởng nhóm: {truongNhom.HoTen}");
        // Console.WriteLine($"Mã nhân viên: {truongNhom.MaNV}");

        // Phạm vi truy cập của thuộc tính và phương thức
        //public: có thể truy cập từ bất kỳ đâu: class con, bên ngoài class
        //private: class con và bên ngoài class không thể truy cập. Chỉ có thể
        //truy cập từ chính class đó.
        //protected: class con có thể truy cập các thuộc tính của class cha
        // nhưng bên ngoài class thì không thể truy cập

        QuanLy quanLy = new QuanLy();
        quanLy.luong= 10000;
        Console.WriteLine($"Lương quản lý: {quanLy.tinhLuong()}");
        // C# check class QuanLy để tìm thuộc tính lương, 
        // nếu không có thì check tiếp  class cha(TruongNhom),
        // nếu không có thì check class cha của class cha (NhanVien)

        // Lưu ý: override:
        // Nếu class con không muốn dùng các logic của phương thức class cha
        // => có thể viết lại phương thức đó trong class con
        // nếu class con muốn dùng lại logic của class cha
        // => có thể dùng từ khóa base.tenPhuongThuc() để gọi phương thức
        // của class cha 
        
    }
}