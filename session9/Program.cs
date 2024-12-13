internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        BaiViet baiviet1 = new BaiViet();
        BaiViet baiviet2 = new BaiViet();
        baiviet1.tieuDe ="CyberSoft";
        baiviet1.hinhAnh ="hinh1.png";
        baiviet1.noiDung = "Nhiều con ngõ ở quận Thanh Xuân lắp barie rào chắn, chặn xe vào giờ cao điểm để tránh ùn tắc, giảm tiếng ồn, đảm bảo an toàn cho người dân trong khu vực.";
        // Console.WriteLine($"Bài viết 1: {baiviet1.tieuDe}, {baiviet1.hinhAnh}, {baiviet1.noiDung}");      
        baiviet1.xuatThongTin();
        Console.WriteLine("===========");
        baiviet2.tieuDe ="Trung Tâm";
        baiviet2.hinhAnh ="hinh2.png";
        baiviet2.noiDung ="Mỏ vàng với trữ lượng ước tính hơn 1.000 tấn và trị giá khoảng 83 tỷ USD được tìm thấy ở tỉnh Hồ Nam, miền trung Trung Quốc.";
        baiviet2.xuatThongTin();

        Student student1 = new Student();
        Student student2 = new Student();
        student1.hoTen="Lê Vũ Long";
        student1.tuoi = 20;
        student1.gioiTinh = "Nam";
        student1.email ="longle23224@gmail.com";
        student1.xuatThongTinStudent();
        Console.WriteLine("=========");
        student2.hoTen="Ân Vũ của Bảo";
        student2.tuoi = 20;
        student2.gioiTinh = "Nữ";
        student2.email ="anvuthienBao@gmail.com";
        student2.xuatThongTinStudent();

        Product product = new Product();
        product.nhapThongTin();
        product.xuatThongTin();

        Rectangle hcn = new Rectangle();
        hcn.nhapThongTin();
        hcn.Tinh();

        // Bài tập nhập môn
        // Tạo đối tượng học sinh(họ tên, tuổi, giới tính, email)
        // Xuất thông tin học sinh
    }
}