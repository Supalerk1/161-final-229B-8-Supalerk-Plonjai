using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    protected string animalName = "";

    private void Start()
    {
        
    }

    public void Initialized()
    {
        Debug.Log("");
    }
    public abstract float CalculateFoodRequirement();

    public virtual void MakeSound() 
    {
        Debug.Log("");
    }

    public  void DisplayName()
    {
        Debug.Log("");
    }

}
