using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Dog :  Animal
{
    private float dailyFoodConsumption;
    private int activityLevel;

    public string name = "";
    public void SetActivityLevel(int _activityLevel) 
    {
        activityLevel = _activityLevel;
        if (activityLevel < 0 ) 
        {
            activityLevel = 0;
            
        }
       
    }

    private void dogMakeSound() 
    {
       
    }

}
