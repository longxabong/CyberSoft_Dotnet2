class Method {
    public static bool checkIsprime(int number){
        for ( int i =2; i<Math.Sqrt(number); i++){
        if(number<2){
            return false;
        }
        if(number % i==0){
            return false;
        }
        }
        return true;
    } 
    public static void tamgiac(int tg)  {
        for (int i = 0; i< tg;i++){
            for(int j = 0; j<=i;j++){
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}