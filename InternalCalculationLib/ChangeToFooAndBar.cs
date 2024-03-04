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
            
            if(CheckInputWithDictionary(i)){ //somehow check if it could be compared to each item on rules
                foreach (var item in rules)
                {
                    if(i%item.Key == 0){
                        placeholder += item.Value;
                    }
                }
            arrayNumber[i] = placeholder;
            placeholder = "";

            }else{
                arrayNumber[i] = i.ToString();
            }
            
        }
        arrayNumber[0] = "0";
        return arrayNumber;
    }

    bool CheckInputWithDictionary(int i){
        foreach (var item in rules)
        {
            if(i%item.Key == 0){
                return true;
            }
        }
        return false;
    }
}