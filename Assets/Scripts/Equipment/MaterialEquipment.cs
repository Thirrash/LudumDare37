using UnityEngine;
using System.Collections.Generic;

public class MaterialEquipment : MonoBehaviour {
    [SerializeField]
    List<Resource> material = new List<Resource>();
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void SortByName()
    {
        material.Sort(
            delegate (Resource r1, Resource r2)
            {
                return r1.objName.CompareTo(r2.objName);
            });
    }
    public void SortByOneObjectWeight()
    {
        material.Sort(
            delegate (Resource r1, Resource r2)
            {
                if(r1.weight > r2.weight)
                {
                    return 1;
                }
                if(r1.weight == r2.weight)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            });
    }
    public void SortByHowMany()
    {

    }
    
}
