abstract class NhanVien{
    private string maNV;
    public string MaNV{
        get{return maNV;}
        set{maNV = value;}
    }
    private string hoTen;
    public string HoTen{
        get{return hoTen;}
        set{ hoTen = value;}
    }

    public NhanVien(string maNV, string hoTen, double luongCoBan){
        this.maNV = maNV;
        this.hoTen = hoTen;
        this.luongCoBan = luongCoBan;
    }
    private double luongCoBan;
    public double LuongCoBan{
        get{return luongCoBan;}
        set{luongCoBan =value;}
    }

    public void chamCong(){
        Console.WriteLine("Cham cong");
    }

    // Hàm abstract này không có thân hàm
    public abstract double tinhLuong();
}