class Bai1{

    public static int tinhTongSoLon50(List<int> IstNumber){
     int tong=0;   
        for (int i =0;i< IstNumber.Count;i++){
            if(IstNumber[0] <50){
                tong += IstNumber[0];
            }
        }
        return tong;
    }

    public static int maxList(List<int> IstNumber){
        int max = IstNumber.ElementAt(0);
        for(int i=0;i<IstNumber.Count;i++){
            if(IstNumber[i]>max){
                max = IstNumber[i];
            }
        }
        return max;
        
    }
}