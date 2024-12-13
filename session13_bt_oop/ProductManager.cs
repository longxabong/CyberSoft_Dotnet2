using Newtonsoft.Json;
class ProductManager{
    private List<Product> products;
    private string filePath = "product.json";
    private void loadData(){
        if(!File.Exists(filePath)){
            products = new List<Product>();
        
        }else {
            string json = File.ReadAllText(filePath);
            products = JsonConvert.DeserializeObject<List<Product>>(json);
        }
    }
    public ProductManager(){
        loadData();
    }
    private void saveData(){
        string json = JsonConvert.SerializeObject(products);
        File.WriteAllText(filePath,json);
    }

    public void addProduct(Product product){
        products.Add(product);
        saveData();
    }

    public void addElectronic(){
        Console.WriteLine("Enter product ID: ");
        int productId = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter product name: ");
        string productName = Console.ReadLine();
        Console.WriteLine("Enter price: ");
        double price = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Description: ");
        string description =Console.ReadLine();
        Console.WriteLine("Warranty: ");
        int warranty = Convert.ToInt32(Console.ReadLine());
        Electronic electronic = new Electronic(productId,productName,price,description,warranty);
        addProduct(electronic);
    }
    public void addFashion(){
        Console.WriteLine("Enter product ID: ");
        int productId = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter product name: ");
        string productName = Console.ReadLine();
        Console.WriteLine("Enter price: ");
        double price = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Description: ");
        string description =Console.ReadLine();
        Console.WriteLine("Size: ");
        string size = Console.ReadLine();
        Fashion fashion = new Fashion(productId,productName,price,description,size);
        addProduct(fashion);
    }

    public void displayAllProducts(){
        // sắp xếp giảm dần theo giá
        // (p1, p2) => p2.Price.CompareTo(p1.Price)
        // => lambda expression
        // syntax 
        // p1(100000), p2(400000), p2
        // products.Sort((p1,p2) => p2.Price.CompareTo(p1.Price));
        // foreach(Product product in products){
        //     product.displayInfo();
        //     Console.WriteLine("=================================");
        // }


        //c2: dùng OrderBy(tăng daafn) hoặc orderByDescending(giảm dần)
        //Orderby thif không làm ảnh hưởng đến list ban đầu
        List<Product> sortedProducts = products.OrderByDescending(p => p.Price).ToList();
        foreach(Product product in products){
            product.displayInfo();
            Console.WriteLine("=================================");
        }
        // sắp xếp giảm dần theo giá tiền và tên sản phẩm
        List<Product> sortedProducts2 = products.OrderByDescending(p => p.Price)
                                                .ThenByDescending(p => p.ProductName)
                                                .ToList();
    }
    public void searchByName(string name){
        // ToLower() => chuyển chuỗi về chữ thường
        // UpLower() => chuyển chuỗi về chữ In
        Product? product = products.Find(p => p.ProductName.Contains(name));
        if(product == null){
            Console.WriteLine("Product not found");
        }else {
            product.displayInfo();
        }
    }
}