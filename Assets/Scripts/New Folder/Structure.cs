using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Structure : MonoBehaviour
{

    public string structureType;
    protected bool buildable;
    protected GameObject[] structuresInScene;
    

    public GameObject[] parts;
    public Structure()
    {
        structuresInScene = GameObject.FindGameObjectsWithTag(structureType);

    }

    private void Update() 
    {
        if (Input.GetKey(KeyCode.Keypad1) && buildable == true)
        {

        }
    }

    public virtual void BuildStructure()
    {

    }

    //public virtual void RandomiseParts(GameObject[], )
}
