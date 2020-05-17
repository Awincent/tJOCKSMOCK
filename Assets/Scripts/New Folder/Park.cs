using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Park : Structure
{

    //works like building, but instead of bottom/middle/top it will place layers of park furniture
    // roads work like bottoms, treeConfigs like middles and furnishing like tops

    protected GameObject[] roads; // Road alternatives
    protected GameObject[] treeConfigs; // Tree placements
    protected GameObject[] furnishing; // Making the park livable

    public override void BuildStructure()
    {

    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
