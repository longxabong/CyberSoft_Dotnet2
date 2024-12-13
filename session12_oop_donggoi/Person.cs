class Person{
    private string name;
    private int age;

    // dùng property để truy cập vào từng thuộc tính
    public string Name{
        get{return name;}
        set{
            // thêm các logic kiểm tra giá trị trước khi
            // gán cho thuộc tính
            // check tên không được rỗng
            // hoặc check tên có độ dài tối thiểu 2 kí tự
            if(string.IsNullOrEmpty(value) || value.Length < 2){
                throw new ArgumentException("tên không hợp lệ");
            }
            name = value;
        }
    }
    public int Age{
        get{return Age;}
        set{
            if(value < 0 || value >200){
                throw new ArgumentException("tuổi không hợp lệ");
            }
        age = value;
        }
    }
    // khi đã define constructor mới, constructor mặc định sẽ không tự sinh ra
    public Person(string name, int age){
        // gán giá trị cho thuộc tính thông qua setter(quan trọng)
        Name = name;
        Age = age;
    }
    public Person(){}
}