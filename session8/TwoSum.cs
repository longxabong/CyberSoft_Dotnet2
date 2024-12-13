using System.Web;

class TwoSum
{
    public static List<int>twoSum (List<int>lst, int target){
        for(int i =0; i<lst.Count-1;i++){
            for(int j =i+1;j<lst.Count;j++){
                 if(lst[i]+ lst[j]== target){
                    return new List<int>{i,j};
                }
            }
        }
        return null;
    }
    public static List<int> twoSumDictionary(List<int> lst, int target){
        // khai bao dictionary de danh dau 
        Dictionary<int,int> seenNumbers = new Dictionary<int, int>();
        for(int i = 0;i<lst.Count;i++){
            int completion = target - lst[i];
            if(seenNumbers.ContainsKey(completion)){
                return new List<int>{seenNumbers[completion],i};
            }
            //neu conpletion ko nam trong dic=> add vao tong dic
            else seenNumbers.Add(lst[i],i);
        }
        return null;
    }
    public static Dictionary<string,int> wordCount(List<string> words)
    {
        Dictionary<string, int> count = new Dictionary<string, int>();
        for(int i =0; i<words.Count;i++){
            if(count.ContainsKey(words[i])){
                count[words[i]]++;
            }
            else count[words[i]]=1;
        
        }
        foreach (string word in words)
        {
            if(count.ContainsKey(word)){
                count[word]++;
            }
            else{
                count[word]=1;
            }
            
        }
        return count;
    }
}

