class Student{
    public string hoTen;
    public int tuoi;
    public string gioiTinh;
    public string email;

    public Student()// Khởi tạo hàm Constructor
    {

    }

    public Student(string hoTen, int tuoi, string gioiTinh, string email){
        this.hoTen = hoTen;
        this.tuoi= tuoi;
        this.gioiTinh = gioiTinh;
        this.email = email;
    }

    public void xuatThongTinStudent(){
        Console.WriteLine($"Thông tin học sinh:");
        Console.WriteLine($"Tên học sinh: {hoTen}");
        Console.WriteLine($"Tuổi: {tuoi}");
        Console.WriteLine($"Giới tính: {gioiTinh}");
        Console.WriteLine($"Email: {email}");
    }
}