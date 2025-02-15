using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* TODO: Problem 5: BARBIES HOUSE
Barbie's House needs to inherit everything from the BarbieWorld class in your
BarbieWorld.cs file. Please modify the BarbieHouse class to inherit from
BarbieWorld and write at least three methods within BarbieHouse representing 
furniture, pets, household items, food, etc. within her house. 
*/ 
public class BarbieHouse : BarbieWorld<string>
{
      public void AddFurniture(string furniture)
    {
        Debug.Log("Barbie added a new furniture: " + furniture);
    }

    public void AdoptPet(string pet)
    {
        Debug.Log("Barbie adopted a new pet: " + pet);
    }

    public void CookFood(string food)
    {
        Debug.Log("Barbie cooked: " + food);
    }

    void Start()
    {

        AddFurniture("Pink Sofa");
        AdoptPet("Coffee Machine");
        CookFood("Pancakes");
    }
}