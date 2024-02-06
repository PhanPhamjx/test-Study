using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Baitap_OOP_01 : MonoBehaviour
{
    public class Animal
    {
        string Name;
        float Height;
        int Age;
        bool Sex;
        public void ShowHang()
        {
            string sex;
            if(Sex == true)
            {
                sex = "male";
            }
            else
            {
                sex = "female";
            }
            Debug.Log("Animal is : " + Name +" " + Height + " " + Age +" " +sex);
        }
        public Animal()
        {

        }
        public Animal(string Name, float Height, int Age, bool Sex)
        {
            this.Name = Name;
            this.Height = Height;
            this.Age = Age;
            this.Sex = Sex;
        }
        public Animal(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }
    }

    void Start()
    {
        Animal ChickenOld = new Animal("chicken old",32f,60,true);
        ChickenOld.ShowHang(); 
    }


}
