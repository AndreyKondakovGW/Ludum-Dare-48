using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour
{
    public int liftscount;
    public List<GameObject> liftplaceholders;
    public List<Lift> lifts;

    public int number;

    private Section controller;

    private HashSet<int> conections = new HashSet<int>();

    /*
    public void generateLifts(){
        lifts = new Lift[liftscount];
        for(int i = 0;i<liftscount;i++){
            lifts[i] = Instantiate(liftPerf);
            lifts[i].transform.SetParent(transform);
            lifts[i].transform.position = liftplaceholders[i].transform.position;
        }
    }*/

    public bool attachedTo(Floor f){
        if (liftplaceholders.Count != 0 && !conections.Contains(f.number)){
            conections.Add(f.number);
            int delta = f.number - number;
            Lift l = generateLift(delta);
            l.attachedTo(f);
            return true;
        }
        return false;
    }

    public Lift generateLift(int type){
        controller = GameObject.FindGameObjectsWithTag("Section")[0].GetComponent<Section>();
        Lift lp = controller.liftPerfs[controller.liftRule[type]];
        Lift l = Instantiate(lp);
        l.transform.SetParent(transform);
        lifts.Add(l);
        GameObject placeholder = liftplaceholders[Random.Range(0, liftplaceholders.Count - 1)];
        liftplaceholders.Remove(placeholder);
        l.transform.position = placeholder.transform.position;
        return l;
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
