internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        NhanVien nguyenVanA = new TruongPhong("NV001", "Nguyen Van A",1000, 1.5);
        Console.WriteLine($"Luowng cua Nguyen Van A: {nguyenVanA.tinhLuong()}");

        // Animal
        Animal dog = new Animal("Chó Tèo");
        dog.eat();
        dog.sleep();

        // Bài tập về quản lý khách sạn
        // abstract class: Room
        // - roomId: string
        // - roomName: string
        // - basePrice: double


        // class con:
        // - normalRoom: Room
        // - LuxuryRoom: Room
        //      + extraService: string
        // - SuitedRoom: Room
        //      + extraService: string
        //      + premiumService: string


    // thêm interface
    // - IWifi: bool hasWifi()


        // class Hotel

        Room normalRoom = new NormalRoom("01", "LoveRoom",400000);
        Room luxuryRoom = new LuxuryRoom("02","ChoTeo",400000,"Fee Breakfast");
        Room suitedRoom = new SuitedRoom("03", "ChoBao", 400000,"Fee Breakfast","Fee massage");
        Console.WriteLine($"Price of normal room: {normalRoom.calculatePrice()}");
        Console.WriteLine($"Price of normal room: {luxuryRoom.calculatePrice()}");
        Console.WriteLine($"Price of normal room: {suitedRoom.calculatePrice()}");

        

    }
}