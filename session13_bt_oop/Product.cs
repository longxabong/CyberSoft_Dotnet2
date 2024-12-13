class Product{
    private int productId;
    // integer: auto increament
    // string(uuid): 
    public int ProductId{
        get{return productId;}
        set{if(value<0){
            throw new ArgumentException("ID must be greater than 0");
        }
        productId = value;}
    }

    // exception
    // 5 loại lỗi phổ biến
    // 1. lỗi logic và tham số(ArgumentExxception,..)
    // 2. lỗi dữ liệu(FormatException,..)
    // 3. lỗi hệ thống
    // 4. Lỗi I/O và mạng
    // 5. lỗi luồng và đa nhiệm
    private string productName;
    public string ProductName{
        get{return productName;}
        set{
            if(string.IsNullOrWhiteSpace(value)){
                throw new ArgumentException("Product name must not be empty");
            }
            productName = value;}
    }

    private double price;
    public double Price{
        get{return price;}
        set{
            if(value<0){
                throw new ArgumentException("Price must be greater than 0");
            }
            price = value;
        }
    }

    private string description;
    public string Description{
        get{return description;}
        set{if(string.IsNullOrWhiteSpace(value)){
            throw new ArgumentException("Description must not be empty");
        }
        description = value;}
    }

    public Product(
        int productId,
        string productName,
        double price,
        string description){
            Console.WriteLine("qưe");
            ProductId = productId;
            ProductName = productName;
            Price = price;
            Description = description;
        }

    public virtual void displayInfo(){
        Console.WriteLine($"Product ID: {ProductId}");
        Console.WriteLine($"Product Name: {ProductName}");
        Console.WriteLine($"Price: {Price}");
        Console.WriteLine($"Description: {Description}");
    }
}