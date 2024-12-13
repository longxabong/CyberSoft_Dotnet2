class NhanVien{
    protected string MaNV;
    private string HoTen {get;set;}
    //mục đích dùng getter  và setter để truy cập vào các thuộc tính private
    public string NgaySinh;
    public string GioiTinh;
    public int tuoi;
    public double luong;

    // overload: nạp chồng phương thức
    // override: ghi đè phương thức của class cha
    public virtual double tinhLuong(){
        return 1000;
    }
}