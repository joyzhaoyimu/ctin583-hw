using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* TODO: Problem 1: GENERICS SHORT ANSWER QUESTIONS
    * What is Unity's `GetComponent<T>`? Why is it considered a generic method?
GetComponent<T> is a method of get a certain component on a game object. "T" means generic, which represents different types without extra labeling different types.
If my unity doesn't have generic vesion of GetComponent<T>(), I need to specifically type out "typeof" manually.



    * In generics, there is a particular convention we follow in defining generics. What leter do we use to represent a placeholder type or generic? In generics, what are the naming conventions used if we have more than one parameter? 
We usually use "T" as placeholder type that it can represent any kinds of component, including Rigidbody, Collider or MeshRenderer.
If we have more than one parameters, which are multiple generic parameters, we can use meaningful naming convention. For example, TKey = Key, TValue = Value.
If it's just multiple type parameters, but with no particular meaning, use T1, T2, T3.




    * What does the generic variable do? Why does it end up as the return type and argument type for a method? 
Generic variable is a placeholder for some unknown type. The reason it is used as the parameterr type and return type of a methods is so thatthe method can be applied to different types of data, without the need to write separate 
methods for each type. This not only makes the code more generic, but also ensures the input and output types are consistent.
Therefore, I don't need to type conversions manually.



    * Give a realistic and detailed example of when you would want to use generics in your game. When would type variables be useful?
For instance, I'm developing an RPG game with various props such as cat, dog, rabbit, which they are all different types. If I don't use generalization, I have to write different methods for each prop.
Such us, public void AddCat(Cat cat){
            petList.Add(cat)};

        public void AddDog(Dog dog){
            petList.Add(dog);
        }
        public void AddRabbit(Rabbit rabbit){
            petList.Add(rabbit));
        }
Everytime I add a new prop I have to write another line.

If I use generalizations, I can make the generalized to make apply to all the props, like a basket. 
    public void AddPet<T>(T pet) where T : Pet{
    inventory.Add(pet);
    }

    AddPet(new Cat("Meow Meow", 2, "Fish"));
    AddPet(new Dog("Woof Woof", 3, "Bone"));
    AddPet(new Rabbit("...", 1, "Carrot"));

If I want to add a new pet, I can directly add with "AddPet()".
Type variables are useful when I need to write code that should work with multiple types.



    * What are the performance implications of using generic arrays as opposed to non-generic arrays in C#?
Generic vs. Non-generic arrays
1. Speed
Generic arrays need no extra convesions that I can just take it out and use it.
Non-generalized arrys need to be converted when storing values, which slow things down.

2. Memory efficient
Data in generic arrays rowed together is faster for the CPU to read.  
Non-generalized arrays store pointers to different locations, taking up more space.  

3. More secure 
Generic arrays can only store one type, will not add data indiscriminately to prevent errors.  
Non-generalized arrays can store various types and may store wrong or even report errors!  



    * What does it mean to instantiate? 
To instantiate means to create a new object of class or a data type in programming. 
It's like using a blueprint (class) to build an actual object that you can interact with.
Without instatiation, I can't interact with the class's properties or methods.



*/

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------
public class BarbieWorld<T>
{
    T item; 
    /* TODO: Problem 2: BARBIE'S CAREERS: Barbie wears many hats. She is a photographer,
    singer, athlete, painter, musician, rockstar, and much more.
    What is the function below trying to accomplish?
ANSWER: The purpose of this function is to let Barbie switch between different careers, such as photographer, singer, or athlete.


    How are we using the T variable in this case?
ANSWER: t is a generic type, meaning that this function can accept any type of career. 
When BarbieCareers(T newCareer) is called, it assigns newCareer to currentCareer, making Barbie a new career.

    Please instantiate an item of this class in  
    your BarbieWalletBalance.cs file in your
    Start() or Update() functions. */
    public void BarbieCareers(T newCareer) {
        currentCareer = newCareer;
    }
    
}