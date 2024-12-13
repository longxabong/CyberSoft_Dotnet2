internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine(tinhtong(1, 2));
        Console.WriteLine("Nhap so: ");
        int number = Convert.ToInt32(Console.ReadLine());
        for (int count = 2; count <= number; count++)
        {
            bool checkPrime = isPrime(count);
            if (checkPrime == true)
            {
                Console.WriteLine($"{count}");
            }
        }

        Console.WriteLine("Mời bạn nhập một số: ");
        int number3 = Convert.ToInt32(Console.ReadLine());
        int originalNumber = number3;
        int reverseNumber = getReverseNumber(number3);
        //tách hàm

        if (reverseNumber == originalNumber){
    Console.WriteLine($"Số {originalNumber} là số đối xứng");
} else {
    Console.WriteLine($"Số {originalNumber} không là số đối xứng");
}
        


    }
    #region 
    private static int getReverseNumber(int number)
    {
        int reverseNumber = 0;
        while (number > 0)
        {
            int lastDigit = number % 10;
            reverseNumber = reverseNumber * 10 + lastDigit;
            number = number / 10;
        }
        return reverseNumber;
    }
    #endregion

    //khai báo hàm kiểm tra số nguyên tố
    private static bool isPrime(int number)
    {
        if (number < 2) return false;
        for (int count = 2; count <= Math.Sqrt(number); count++)
        {
            if (number % count == 0)
            {
                return false;
            }
        }
        return true;
    }
    private static int tinhtong(int number1, int number2)
    {
        return number1 + number2;

    }


}

