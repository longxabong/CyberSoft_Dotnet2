class Animal: IEat, ISleep{
    private string name;
    public string Name{
        get{return name;}
        set{ name = value;}
    }
    public Animal(string name){
        this.name = name;
    }
    // Lưu ý là định nghĩa lại hàm eat và sleep thì phải đúng tên hàm và kiểu dữ liệu trả về
    // Định nghĩa lại hàm eat dành riêng ho class Animal
    public void eat(){
        Console.WriteLine("Animal is eating");
    }
    // Định nghĩa lại hàm sleep dành riêng cho class Animal
    public void sleep(){
        Console.WriteLine("Animal is sleeping");
    }
}