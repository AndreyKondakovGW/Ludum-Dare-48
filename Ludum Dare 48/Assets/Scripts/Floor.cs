using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour
{
    public int liftscount;
    public Lift liftPerf;
    public GameObject[] liftplaceholders;
    public Lift[] lifts;

    public int number;


    public void generateLifts(){
        lifts = new Lift[liftscount];
        for(int i = 0;i<liftscount;i++){
            lifts[i] = Instantiate(liftPerf);
            lifts[i].transform.SetParent(transform);
            lifts[i].transform.position = liftplaceholders[i].transform.position;
        }
    }

//   public Lift getNoAttachedLift(){
//    }
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
