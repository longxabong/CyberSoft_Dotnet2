class BaiViet {
    public string tieuDe;
    public string noiDung;
    public string hinhAnh;

    public void xuatThongTin(){
        Console.WriteLine("Thông tin bài viết là:");
        Console.WriteLine($"Tiêu đề:{tieuDe}");
        Console.WriteLine($"Nội dung:{noiDung}");
        Console.WriteLine($"Hình ảnh: {hinhAnh}");
    }

}