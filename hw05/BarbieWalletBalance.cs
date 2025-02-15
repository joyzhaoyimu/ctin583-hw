using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarbieBank, BarbieWalletBalance : MonoBehaviour
{

    void Start() {
    BarbieCareers<string> barbieJob = new BarbieCareers<string>(); 
    barbieJob.BarbieCareers("Photograph"); 
}


    // Start is called before the first frame update

    /* TODO: Problem 3: BARBIE'S BANK
    Convert the following function to a generic if needed. 
    Then, write a private generic function named BarbieBank. 
    BarbieBank should take in the parameters: numOfPennies, cashAmount, and numOfCreditCards
    Have the function return a new generic array with the correct parameters. 
    */
private T[] BarbieBank<T>(T numOfPennies, T cashAmount, T numOfCreditCards)
{
    return new T[] { numOfPennies, cashAmount, numOfCreditCards };
}

void Start()
{
    int[] biggerWallet = BarbieBank(500, 600, 2);
    Debug.Log(biggerWallet.Length + " " + biggerWallet[0] + " " + biggerWallet[1] + " " + biggerWallet[2]);

    float[] fancyWallet = BarbieBank(500.5f, 600.75f, 3.0f);
    Debug.Log(fancyWallet.Length + " " + fancyWallet[0] + " " + fancyWallet[1] + " " + fancyWallet[2]);
}


    /* TODO: Problem 4: INHERITANCE: SHORT ANSWERS
        * What is the "Protected" access modifier? How does it relate to inheritence and between two classes. 
Protected means a variable or method can be accessed within the class itself and by any derived (child) classes, but not by other external classes.
Inheritance: If a parent class has protected members, its child class can directly access them.


        * What is MonoBehaviour? Why do Unity C# scripts inherit from MonoBehaviour? Give some examples of Unity functions that come from MonoBehaviour. 
MonoBehaviour is Unity's base class for scripts that run in the scene.
Unity scripts must inherit from MonoBehaviour to use built-in functions like Start(), Update(), OnTriggerEnter(), etc.
It allows scripts to be attached to GameObjects and interact with Unity's engine.

        * What is multiple inheritance? Can we perform multiple inheritance in C#? Why or why not?
Multiple inheritance means a class can inherit from more than one parent class.
C# does not support multiple inheritance to avoid complexity and conflicts (like the "diamond problem").
Instead, C# uses interfaces to achieve similar behavior.

        * What does "Protected virtual void" mean? When is it needed and what does virtual do in your code?
protected : The method can be used inside this class and by child classes.
virtual : The method can be overridden in child classes.
I use it when I want child classes to modify the behavior of a parent method.

        * What happens when a constructor in a parent class is called? How do we control which base class contructor is being called?
When a child class is created, the parent class's constructor runs first before the child class's constructor.
I use base() to explicitly call a specific parent constructor.

     */ 
    private void KenWallet<T1, T2>(T1 money, T2 moreMoney) {
        Debug.Log(money.GetType());
        Debug.Log(moreMoney.GetType());
    }
}