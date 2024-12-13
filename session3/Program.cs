// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// See https://aka.ms/new-console-template for more information
#region Bài 1: Tính số ngày trong tuần và số ngày lẻ
Console.WriteLine("Nhập số ngày: ");
string? ngay = Console.ReadLine();
int day = Convert.ToInt32(ngay);
int week = day/7;
int days = day%7;
Console.WriteLine($"Số tuần: {week}");
Console.WriteLine($"Số ngày: {days}");
#endregion



#region Bài 2: Tính tổng giá trị đơn hàng sau khi giảm giá
Console.WriteLine("Nhập giá sản phẩm(VND)");
string? giA = Console.ReadLine();
double pricE = Convert.ToDouble(giA);

Console.WriteLine("Nhập phần trăm giảm giá sản phẩm(không quá 100%)");
string? giamgia = Console.ReadLine();
double discount = Convert.ToDouble(giamgia);

double tienGiam = pricE*discount/100;
double thanhToan = pricE - tienGiam;

Console.WriteLine($"Số tiền được giảm: {tienGiam} VND");
Console.WriteLine($"Số tiền cần thanh toán: {thanhToan} VND");
#endregion



#region Bài 3: Chuyển đổi thời gian từ phút sang giờ và phút
Console.WriteLine("Nhập số phút cần đổi: ");
string? phut = Console.ReadLine();
int minutes = Convert.ToInt32(phut);
int hours = minutes/60;
int minute = minutes%60;
Console.WriteLine($"Số giờ: {hours}");
Console.WriteLine($"Số phút: {minute}");
#endregion



#region Bài 4: Tính tổng số tiền sau khi cộng thêm thuế VAT
Console.WriteLine("Nhập số tiền gốc của sản phẩm(VND): ");
string? gia = Console.ReadLine();
double price= Convert.ToDouble(gia);

Console.WriteLine("Nhập tỷ lệ thuế VAT(%): ");
string? vat = Console.ReadLine();
double VAT= Convert.ToDouble(vat);

double tongTien = price + price*VAT/100;
Console.WriteLine($"Tổng số tiền sau khi đã cộng thêm thuế VAT: {tongTien}");
#endregion



#region Bài 5: Chuyển đổi đơn vị tiền tệ

double doi = 25000;
Console.WriteLine("Nhập số tiền cần đổi(USD): ");
string? usd = Console.ReadLine();
double USD = Convert.ToDouble(usd);

double vnd = USD*doi;
Console.WriteLine($"Số tiền sau khi đổi(VND): {vnd} VND");
#endregion
