﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomBuilding_mk1 : MonoBehaviour
{

    // THis 

    public int buildingHeight;
    private int middleAmount;

    public List<GameObject> buildingParts;

    public GameObject[] bottoms;
    public GameObject[] middles;
    public GameObject[] tops;

    public GameObject targetBuilding;
    GameObject[] finishedBuilding;

    public List<GameObject> buildings;
    public GameObject[] buildingsInScene;

    public bool buildable = true;
    private bool paused;
    private Vector3 temp = new Vector3(0, 0, 0);//targetBuilding.transform.position;

    [Range(0, 10)]
    public float randomHeight; 

    GameObject[] placedParts;

    void Update()
    {

        if (Input.GetKey(KeyCode.Keypad1) && buildable == true)
        {
            buildable = false;

            buildingsInScene = GameObject.FindGameObjectsWithTag("Building");

        for (int i = 0; i < buildingsInScene.Length; i++)
        {
            buildings.Add(buildingsInScene[i]);
        }

        middleAmount = buildingHeight - 2;

            BuildBuilding();
        }

        if (Input.GetKey(KeyCode.F))
        {

            placedParts = GameObject.FindGameObjectsWithTag("Part");

            foreach (var gameObject in placedParts)
            {

                Rigidbody tempRb = gameObject.GetComponent<Rigidbody>();
                Destroy(tempRb);
            }
        }

    }

    public void DesignBuilding()
    {
        buildingParts.Clear();

        buildingParts.Add(bottoms[Random.Range(0,bottoms.Length)]);

        AddMiddles();

        buildingParts.Add(tops[Random.Range(0,tops.Length)]);

        finishedBuilding = buildingParts.ToArray();
    }

    public void AddMiddles()
    {
        int tempHeight = Random.Range(middleAmount - (int)randomHeight , middleAmount + (int)randomHeight);
        
        for (int i = 0; i < tempHeight; i++)
        {
            buildingParts.Add(middles[Random.Range(0,middles.Length)]);
        }

    }

    public void BuildBuilding()
    {
             
        foreach (var GameObject in buildings)
        {
            DesignBuilding();
            temp = GameObject.transform.position;
            
            for (int i = 0; i < finishedBuilding.Length; i++)
            {               
                //temp = finishedBuilding[i].gameObject.transform.position;
                Instantiate(finishedBuilding[i], temp + new Vector3(0, i + 3, 0), Quaternion.identity, transform.parent);
            }

            //buildings.RemoveAt(0);
                        
        } 
        
    }
}
