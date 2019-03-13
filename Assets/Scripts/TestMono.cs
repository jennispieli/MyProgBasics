using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMono : MonoBehaviour {
    
    string myName ="Jennifer";
    
        public void PrintDebug() {
        Debug.Log("Angeklickt"); 
    }
         public void PrintMyName(string myNameis) {
        Debug.Log("mein Name ist:" + myNameis); 
    }
    
    public void AddNumbers(int first, int second){
        Debug.Log("Add Nubers: first +second" + (first + second));
    }
    
    public void MultiplyNumbers(int first, int second, int third) {
        Debug.Log("MultipleNumbrs: first * second * third" +(first*second*third));
    } 
    
    public void DivideNumbers(float first, float second, float third) {
        Debug.Log("DivideNumbers: first : second : third " + first/second/third);
    }
    
    public void ConcatinateStrings(string myName, string msg) {
        Debug.Log("First Concatination " +myName + " , " +msg);
    }

	// Use this for initialization
	void Start () {
		PrintDebug();
        PrintMyName("Jenni");
        AddNumbers(1,2);  
        MultiplyNumbers(1,99,7);
        DivideNumbers(20.0f,2.0f,45.0f);
        ConcatinateStrings("Jenni", "heute ist ein schöner Tag");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
