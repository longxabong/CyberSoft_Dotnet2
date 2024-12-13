﻿
internal class Program
{
    private static void Main(string[] args)
    {
        #region lý thuyết đóng gói trong OOP
        // Console.WriteLine("Hello, World!");
        // tính đóng gói trong OOP( encapsulation)
        // giới hạn phạm vi truy cập của các thuộc tính trong các class
        // nhằm bảo vệ dữ liệu của class
        // =>> các thuộc tính của class nên được khai báo là private
        // để truy cập vào các thuộc tính đó, ta sử dụng phương thức
        // getter và setter
        // tạo đối tượng person
        // dùng try catch để bắt lỗi nếu có lỗi xảy ra
        // try{
        //     Person person = new Person();
        //     //person.name ="Nguyen Van A" // lỗi vì name là private
        //     person.Name = "Nguyen Van A"; // đi qua setter của Name
        //     Console.WriteLine(person.Name);

        //     // person.Name = "A";
        //     // Console.WriteLine(person.Name);
        //     Console.WriteLine("========");
        //     Person person1 = new Person("aa",13);
        // }
        // catch(ArgumentException ex){
        //     Console.WriteLine(ex.Message);
        // }
        #endregion



        #region 
        // 1. Tạo class cha Vehicle
        // - vehicleId: mã phương tiện
        // - brand: hãng xe
        // - year: năm sản xuất
        // - price: giá xe
        // 1.1 Tạo class Car kế thừa từ Vehicle
        // - model: dòng xe
        // - color: màu xe
        // - engine: dung tích động cơ
        // 1.2 Tạo class Motor kế thừa từ Vehicle
        // - type: loại xe (số tay, số tự động)
        // - power: công suất
        // Tạo class VehicleManager để quản lý phương tiện giao thông
        // - danh sách phương tiện
        // - file json lưu thông tin phương tiện (nâng cao)
        // 3. Yêu cầu chức năng
        // - Thêm phương tiện vào danh sách
        // * check xem mã phương tiện đã tồn tại chưa. Nếu có rồi thì báo lỗi.
        // lưu phương tiện mới vào file json (sử dụng thư viện Newtonsoft.Json)
        // - Hiển thị danh sách phương tiện
        // - Tìm phương tiện theo mã phương tiện
        // - Thoát

        // tạo đối tượng vehicleManager
        VehicleManager vehicleManager = new VehicleManager();
        bool isRunning =true;
        while(isRunning){
            Console.WriteLine("1. Thêm phương tiện xe hơi");
            Console.WriteLine("2. Hiển thị danh sách phương tiện");
            Console.WriteLine("3. Exit");
            Console.WriteLine("4. Chọn chức năng (1-3):");

            int choice  = Convert.ToInt32(Console.ReadLine());
            switch(choice){
                case 1: 
                    vehicleManager.addCar();
                    break;
                case 2:
                    vehicleManager.displayAllvehicle();
                    break;
                case 3:
                    isRunning =false;
                    break;
                default:
                    Console.WriteLine("chuc nang khong hợp lệ");
                    break;
            }
        }
        #endregion
    }
}