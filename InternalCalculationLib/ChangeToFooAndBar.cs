namespace InternalCalculationLib;

public class ChangeToFooAndBar{
    Dictionary<int, string> rules;

    public ChangeToFooAndBar(){
        rules = new();
        rules.Add(3, "foo");
        rules.Add(5, "bar");
    }

    public bool AddRules(int number, string word){
        rules.Add(number, word);
        return true;
    }

    public string[] Run(string input){
        int.TryParse(input, out int inputInt);
        
        string[] arrayNumber = new string[inputInt+1];

        string placeholder = "";
        
        for(int i=0; i<inputInt+1; i++){
            
            if(i%3 == 0 && i%5 == 0){
                // rules.Values.Contains
            }else{
                arrayNumber[i] = i.ToString();
            }
            foreach (var item in rules)
            {
                if(i%item.Key == 0){
                    placeholder += item.Value;
                }
            }
            
            placeholder = "";
        }
        arrayNumber[0] = "0";
        return arrayNumber;
    }

    // public static string[] Run(string input){
    //     int.TryParse(input, out int inputInt);
        
    //     string[] arrayNumber = new string[inputInt+1];
        
    //     for(int i=0; i<inputInt+1; i++){
            
    //         if(i%3 == 0 && i%5 == 0){
    //             arrayNumber[i] = "Foobar";
    //         }else if(i%3 == 0){
    //             arrayNumber[i] = "Foo";
    //         }else if(i%5 == 0){
    //             arrayNumber[i] = "bar";
    //         }else{
    //             arrayNumber[i] = i.ToString();
    //         }
    //     }
    //     arrayNumber[0] = "0";
    //     return arrayNumber;
    // }
}