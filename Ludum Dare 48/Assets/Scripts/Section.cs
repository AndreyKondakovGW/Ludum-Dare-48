using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum LiftGernerationStrategy{
    Original,
    Random
} 
public class Section : MonoBehaviour
{
    public string sectionName;
    public int size;
    public int distaceBeetwenFloors;
    public LiftGernerationStrategy strategy;

    public Floor floorPerf;
    public Floor[] floors;

    public void setPropertice(int s, string n)
    {
        sectionName = n;
        size = s;
    }

    public void GenerateFloors(){
        floors = new Floor[size];
        for(int i=0;i<size;i++){
            floors[i] = Instantiate(floorPerf);
            floors[i].generateLifts();
            floors[i].transform.position = new Vector3(0, 0 - distaceBeetwenFloors*i, 0);
        }
    }

    public void attacheLifts(){
        if (strategy == LiftGernerationStrategy.Original){
            for(int i=0;i<size;i++){
                Debug.Log(i);
                Debug.Log(floors[i].lifts.Length);

                if (i > 0){
                    floors[i].lifts[0].attachedTo(floors[i - 1].lifts[0]);
                }
                if (i + 2 < size){
                    floors[i].lifts[1].attachedTo(floors[i + 2].lifts[1]);
                }
            }
        }
        
    }
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
