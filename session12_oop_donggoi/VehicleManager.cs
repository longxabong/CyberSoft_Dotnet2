using Newtonsoft.Json;
class VehicleManager{
    private List<Vehicle> vehicles = new List<Vehicle>();
    public List<Vehicle> Vehicles {
        get{return vehicles;}
        set{vehicles = value;}
    }
    private string filePath = "vehicles.json";

    // Viết hàm load Data đêt đọc dữ liệu từ file json
    // dùng thư viện Newtonsoft.json
    private void loadData(){  // dùng trong constructor
        // kiểm tra file có tồn tại không
        if(File.Exists(filePath)){
            // đọc dữ liệ từ file json
            string json = File.ReadAllText(filePath);
            // chuyển dữ liệu từ file json sang List<Vehicle>
            Vehicles = JsonConvert.DeserializeObject<List<Vehicle>>(json);
        } else{
            Vehicles = new List<Vehicle>();
        }
    }

    // Constructor
    public VehicleManager(){ 
        loadData();
    }

    // viết hàm saveDate để lưu dữ liệu vào file json
    private void saveData(){// dùng trong hàm add Vehicle và remoteVehicle
        loadData();
        // chuyển dữ liệu từ List<Vehicle> sang string json
        string json = JsonConvert.SerializeObject(Vehicles, Formatting.Indented);

        // lưu dữ liệu vào file json
        File.WriteAllText(filePath, json);
    }

    // viết hàm addVehicle để thêm phương tiện vào danh sách
    public void addVehicle(Vehicle vehicle){
        // kiểm tra mã phương tiện đã tồn tại chưa
        // lamda expression
        Vehicle vehi = Vehicles.Find(v => v.VehicleId == vehicle.VehicleId);
        if(vehi != null){
            throw new ArgumentException("Mã phương tiên đã tồn tại");
        }
        Vehicles.Add(vehicle);
        saveData();
        Console.WriteLine("Thêm phương tiện thành công");
    }

    // viết hàm addCar để thêm xe vào danh sách 
    public void addCar(){
        Console.WriteLine("Nhập mã phương tiện");
        string vehicleId = Console.ReadLine();
        Console.WriteLine("Nhập hãng");
        string brand = Console.ReadLine();
        Console.WriteLine("Nhập năm sản xuất");
        int year = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhập giá: ");
        double price = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nhập dòng xe");
        string model = Console.ReadLine();
        Console.WriteLine("Nhập màu xe");
        string color = Console.ReadLine();
        Console.WriteLine("Nhập dung tích");
        int engine =Convert.ToInt32(Console.ReadLine());


        Car car = new Car(vehicleId, brand, year, price, model, color, engine);
        addVehicle(car);
    }

    // viết hàm displayAllvehicle để hiển thị danh sách phương tiện
    public void displayAllvehicle(){
        Console.WriteLine("\n=== Danh sách phương tiện ===");
        foreach(Vehicle vehicle in Vehicles){
            vehicle.displayInfo();
            Console.WriteLine("----------------------");
        }
    }
}