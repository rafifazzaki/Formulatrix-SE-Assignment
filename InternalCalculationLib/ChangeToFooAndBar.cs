﻿namespace InternalCalculationLib;

public class ChangeToFooAndBar{
    public static string[] Run(string input){
        int.TryParse(input, out int inputInt);
        
        string[] arrayNumber = new string[inputInt+1];
        // inputInt = 15
        // tapi arrayNumber[0-14]
        // int i = 0;
        // do{
        //     if(i%3 == 0 && i%5 == 0){
        //         arrayNumber[i] = "Foobar";
        //     }else if(i%3 == 0){
        //         arrayNumber[i] = "Foo";
        //     }else if(i%5 == 0){
        //         arrayNumber[i] = "bar";
        //     }else{
        //         arrayNumber[i] = i.ToString();
        //     }
        //     i++;
        // }while(i<inputInt);

        // while(i<inputInt){
        //     if(i%3 == 0 && i%5 == 0){
        //         arrayNumber[i] = "Foobar";
        //     }else if(i%3 == 0){
        //         arrayNumber[i] = "Foo";
        //     }else if(i%5 == 0){
        //         arrayNumber[i] = "bar";
        //     }else{
        //         arrayNumber[i] = i.ToString();
        //     }
        //     i++;
        // }
        
        
        for(int i=0; i<inputInt+1; i++){
            
            if(i%3 == 0 && i%5 == 0){
                arrayNumber[i] = "Foobar";
            }else if(i%3 == 0){
                arrayNumber[i] = "Foo";
            }else if(i%5 == 0){
                arrayNumber[i] = "bar";
            }else{
                arrayNumber[i] = i.ToString();
            }
        }
        arrayNumber[0] = "0";
        return arrayNumber;
    }
}