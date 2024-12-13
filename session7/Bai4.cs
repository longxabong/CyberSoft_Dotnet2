class Bai4{
    public static List<int> istNumber(List<int> istNumber){
        List<int> resultss = new List<int>();
        resultss.Add(istNumber.ElementAt(0));
        for(int i=0;i<istNumber.Count;i++){
            if(istNumber[i]!= istNumber[i-1]){
                resultss.Add(istNumber[i]);
            }
        }
        return resultss;
    }
}