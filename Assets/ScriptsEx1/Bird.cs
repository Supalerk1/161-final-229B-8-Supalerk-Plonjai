using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Bird : Animal
{
    private float dailyFoodConsumption;
    private float weight;

     string animalName = "This is a Bird";

    private float _weight 
    {
        
        get {  return weight; } set { weight = value;  }
        
    }

    private void birdMakeSound() 
    {
       
    }


    private float _dailyFoodConsumption() 
    {
        return dailyFoodConsumption;
    }

}
