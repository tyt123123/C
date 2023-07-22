using UnityEditor;
using UnityEngine;
namespace _Script.Entity
{
    public class Student
    {
        private int id;
        private  string name;
        public int ID
        {
            get => id;
            set => id = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        

        public void Print()
        {
            Debug.Log($"{this.Name}");
        }
    }
}