internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Mời bạn nhập số: ");
        int number = Convert.ToInt32(Console.ReadLine());
        for(int i =2; i <= number; i++)
        {
            bool checkNT = checkSonguyento(i);
            if(checkNT){
                Console.WriteLine($"{i}");
            }
        }
        Console.WriteLine("Mời bạn nhập số: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        bool reverseNumber = checkDoiXung(number2);
        if(reverseNumber){
            Console.WriteLine($"So {number2} la so doi xung");
        }
        else Console.WriteLine($"So {number2} khong phai la so doi xung");
    }
    private static bool checkDoiXung(int number2)
    {   
        int originalNumber = number2;
        int reverseNumber = 0;
        while(number2>0)
        {
            int lastDigit = number2%10;
            reverseNumber = reverseNumber*10 +lastDigit;
            number2 = number2/10;
        }
        if(reverseNumber == originalNumber){
            return true;
        }
        else return false;
    }
    private static bool checkSonguyento(int number)
    {
        for(int j =2; j<= Math.Sqrt(number);j++)
        {
            if(number%j == 0)
            return false;
        }
        if(number<2){
            return false;
        }
        return true;
    }
    
}




// #region Nhập số N từ bàn phím. In ra các số nguyên tố từ 2 đến N.
// Console.WriteLine("Mời bạn nhập số: ");
// int number = Convert.ToInt32(Console.ReadLine());
// for(int i =2; i<=number;i++)
// {
//     bool isPrime =true;
//     for(int j = 2; j <= Math.Sqrt(i);j++){
//         if(i%j ==0){
//             isPrime =false;
//             break;
//         }
//     }
//     if(isPrime){
//         Console.WriteLine(i);
//     }
// }
// #endregion




// #region Nhập số N từ bàn phím. Kiểm tra số đó có đối xứng không?
// Console.WriteLine("Mời bạn nhập số: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int reverseNumber = 0;
// int originalNumber = number;

// while (number > 0)
// {
//     int lastDigit = number % 10;
//     reverseNumber = reverseNumber * 10 + lastDigit;
//     number = number / 10;
// }
// if (originalNumber == reverseNumber)
// {
//     Console.WriteLine($"Số {originalNumber} là số đối xứng");
// }
// else Console.WriteLine($"Số {originalNumber} không phải là số đối xứng");
// #endregion




// #region Nhập chiều cao tam giác, in ra tam giác cân rỗng.
// Console.WriteLine("Mời bạn nhập dòng: ");
// int number = Convert.ToInt32(Console.ReadLine());
// for (int i = 0; i < number; i++)
// {
//     for (int j = 0;j<number -i -1 ; j++)
//     {
//         Console.Write(" ");
//     }
//     for(int k =0; k< i*2+1;k++){
//         if(k ==0 || k ==i*2 || i == 0|| i== number -1){
//             Console.Write("*");
//         }
//         else Console.Write(" ");
//     }
//     Console.WriteLine();
// }
// #endregion