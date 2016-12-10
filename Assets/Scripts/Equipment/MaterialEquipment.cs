using UnityEngine;
using System.Collections.Generic;
using System;

public class MaterialEquipment : MonoBehaviour {
    [SerializeField]
    List<Resource> material = new List<Resource>();
    private PlayerStatistics _stat;
    GameObject materialsObj;

	void Start () {
        _stat = GetComponent<PlayerStatistics>();
        materialsObj = new GameObject( "Materials" );
        materialsObj.transform.parent = gameObject.transform;
	}


    public List<Resource> GetList()
    {
        return material;
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
        material.Sort(
            delegate (Resource r1, Resource r2)
            {

                if (r1.currObjects > r2.currObjects)
                {
                    return 1;
                }
                if (r1.currObjects == r2.currObjects)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            });
    }

    public void Add(Resource r)
    {
        float eqWeight=0;
        foreach(Resource rr in material)
        {
            eqWeight += rr.weight * rr.currObjects;
        }
        _stat.currWeight = eqWeight;
        if(eqWeight < _stat.maxWeight )
        {
            if(CheckExist(r) != null)
            {
                CheckExist(r).currObjects += 1;
            }
            else
            {
                Resource newR = materialsObj.AddComponent<Resource>( );
                newR.CopyFrom( r );
                material.Add(newR);
            }
        }
    }
    Resource CheckExist(Resource r)
    {
        foreach (Resource rr in material)
        {
            if (r.objName == rr.objName)
            {
                return rr;
            }
        }
        return null;
    }
    public void Mainus(Resource r)
    {

    }
}
