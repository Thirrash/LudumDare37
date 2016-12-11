using UnityEngine;
using System.Collections.Generic;
[System.Serializable]
public struct Trees
{
    public GameObject Tree1;
    public GameObject Tree2;
    public GameObject Tree3;
}

public class Forest : MonoBehaviour {
    public List<GameObject> spawnLeafy = new List<GameObject>();
    public List<GameObject> spawConiferous = new List<GameObject>();
    public List<GameObject> spawnDeflaut = new List<GameObject>();
    public Trees leafy;
    public Trees coniferous;
    public int leafyTree;
    public int coniferousTree;
    public int deflaut;
    public int all;

    private List<GameObject> _treeLeafy = new List<GameObject>();
    private List<GameObject> _treeConiferous = new List<GameObject>();
    private List<GameObject> _treeDeflaut = new List<GameObject>();

    // Use this for initialization
    void Start () {
        all = leafyTree + coniferousTree + deflaut;
        AddTreeExiste(spawConiferous);
        AddTreeExiste(spawnDeflaut);
        AddTreeExiste(spawnLeafy);
        createForest(_treeConiferous, spawConiferous, coniferousTree, coniferous);
        createForest(_treeLeafy, spawnLeafy, leafyTree, leafy);
        createForest(_treeDeflaut, spawnDeflaut, deflaut);
	}
	
	// Update is called once per frame
	void Update () {
        //ClearList(_treeLeafy);
        //ClearList(_treeDeflaut);
        //ClearList(_treeConiferous);
        //if(_treeLeafy.Count<leafyTree)
        //{
        //    createForest(_treeLeafy, spawnLeafy, leafyTree - _treeLeafy.Count, leafy);
        //}
        //if (_treeConiferous.Count < coniferousTree)
        //{
        //    createForest(_treeConiferous, spawConiferous, coniferousTree - _treeConiferous.Count, coniferous);
        //}
        //if (_treeDeflaut.Count < deflaut)
        //{
        //    createForest(_treeLeafy, spawnLeafy, leafyTree - _treeDeflaut.Count, leafy);
        //}


    }
    void createForest(List<GameObject> Forest, List<GameObject> spawnd , int howMany, Trees tr)
    {
        for(int  p = 0; p<howMany;)
        {
            GameObject az = RandSpawn(spawnd);
            if(az.GetComponent<TreeeExist>().existe == false)
            {
                GameObject pl = Instantiate(RandPrefab(tr), az.transform.position, Quaternion.identity, az.transform) as GameObject;
                az.GetComponent<TreeeExist>().setTree(pl);
                p++;
            }
            
        }
        
    }
    void createForest(List<GameObject> Forest, List<GameObject> spawnd, int howMany)
    {
        for (int p = 0; p < howMany;)
        {
            GameObject az = RandSpawn(spawnd);
            if (az.GetComponent<TreeeExist>().existe == false)
            {
                GameObject pl = Instantiate(RandPrefab(leafy, coniferous), az.transform.position, Quaternion.identity, az.transform) as GameObject;
                az.GetComponent<TreeeExist>().setTree(pl);
                p++;
            }
        }

    }

    GameObject RandPrefab(Trees tr, Trees tr2)
    {
        float z = Random.Range(1, 6);
        z = Mathf.Round(z);
        if (z == 1)
        {
            return tr.Tree1;
        }
        if (z == 2)
        {
            return tr.Tree2;
        }
        if(z == 5)
        {
            return tr.Tree3;
        }
        if (z == 4)
        {
            return tr2.Tree1;
        }
        if (z == 5)
        {
            return tr2.Tree2;
        }
        else
        {
            return tr2.Tree3;
        }
    }
    GameObject RandPrefab(Trees tr)
    {
        float z = Random.Range(1, 3);
        z = Mathf.Round(z);
        if(z == 1)
        {
            return tr.Tree1;
        }
        if (z == 2)
        {
            return tr.Tree2;
        }
        else
        {
            return tr.Tree3;
        }
    }
    void AddTreeExiste(List<GameObject> l)
    {
        foreach(GameObject b in l )
        {
            b.AddComponent<TreeeExist>();
        }
    }
    GameObject RandSpawn(List<GameObject> l)
    {
        int z = (int)Random.Range(0, l.Count);
        {
            return l[z];
            
        }
    }

    void ClearList(List<GameObject> l)
    {
        l.RemoveAll( x => x == null);
    }
    
}
