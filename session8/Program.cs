internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        List<int> lst = new List<int>{2,7,9,11,15};
        int target = 9;
        // Console.WriteLine("Bai1: Tim 2 chi so nguyen ");
        // if(TwoSum.twoSum(lst,target)==null){
        //     Console.WriteLine("Khong co hai so dat gia tri target");
        // }
        // else{
        //     List<int> indexes= TwoSum.twoSum(lst,target);
        //     Console.WriteLine($"Chi so 2 so co tong bang target: {string.Join(',', indexes)}");

        // }

        Dictionary<int,int> dic = new Dictionary<int, int>();

        Console.WriteLine("dung dictionary");
        if(TwoSum.twoSumDictionary(lst,target)==null){
            Console.WriteLine("Khong co hai so dat gia tri target");
        }
        else{
            List<int> indexes= TwoSum.twoSumDictionary(lst,target);
            Console.WriteLine($"Chi so 2 so co tong bang target: {string.Join(',', indexes)}");

        }

        List<string> str = new List<string>{"apple", "mango", "melon", "apple", "pineapple", "mango"};
    }
    
}