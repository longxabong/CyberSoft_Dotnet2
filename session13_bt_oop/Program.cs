internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        // Bài tập về quản lý cửa hàng
        // class:
        // - Product(cha)
        //

        ProductManager  productManager = new ProductManager();
        bool isRunning = true;
        while(isRunning){
            Console.WriteLine("\n=== Product Management ===");
            Console.WriteLine("1. Add electronic");
            Console.WriteLine("2. Add fashion");
            Console.WriteLine("3. Display all products");           
            Console.WriteLine("4. Search by name");            
            Console.WriteLine("5. Exit");            
            Console.WriteLine("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch(choice){
                case 1:
                try {
                    productManager.addElectronic();
                    break;
                    } 
                catch (ArgumentException ex){
                    Console.WriteLine(ex.Message);
                    break;
                }
                case 2:
                productManager.addFashion();
                break;
                case 3:
                productManager.displayAllProducts();
                break;
                case 4:
                Console.WriteLine("Enter your Product Name: ");
                string name = Console.ReadLine();
                productManager.searchByName(name);
                break;
                case 5:
                isRunning = false;
                break;
                default:
                Console.WriteLine("Invalid choice");
                break;

            }

        }
    }
}