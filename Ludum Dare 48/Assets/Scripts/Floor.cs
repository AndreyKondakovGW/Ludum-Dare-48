using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour
{
    [SerializeField]
    public GameObject[] roomPerfSolo;
    [SerializeField]
    public GameObject[] roomPerfCornersR;
    [SerializeField]
    public GameObject[] roomPerfCornersL;
    [SerializeField]
    public GameObject[] roomPerfCenter;

    private GameObject[] rooms;

    public int liftscount;
    public List<GameObject> liftplaceholders;
    public List<Lift> lifts;

    public int number;

    private Section controller;

    private HashSet<int> conections = new HashSet<int>();

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

    public void GenerateRooms(int size){
        rooms = new GameObject[size];
        if (size == 1){
            rooms[0] = Instantiate(roomPerfSolo[Random.Range(0,roomPerfSolo.Length)]);
            rooms[0].transform.SetParent(transform);
            rooms[0].transform.position = new Vector3(transform.position.x, transform.position.y, 0);
            return;
        }
        if (size > 1){
            rooms[0] = Instantiate(roomPerfCornersL[Random.Range(0,roomPerfCornersL.Length)]);
            rooms[0].transform.SetParent(transform);
            rooms[0].transform.position = new Vector3(((size / 2) -size + 1)*40, transform.position.y, 0);
            for (int i = 1;i < size - 1;i++){
                rooms[i] = Instantiate(roomPerfCenter[Random.Range(0,roomPerfCenter.Length)]);
                rooms[i].transform.SetParent(transform);
                rooms[i].transform.position = new Vector3((i - (size / 2))*40, transform.position.y, 0);
            }
            rooms[size - 1] = Instantiate(roomPerfCornersR[Random.Range(0,roomPerfCornersR.Length)]);
            rooms[size - 1].transform.SetParent(transform);
            rooms[size - 1].transform.position = new Vector3((size - 1 - (size / 2))*40, transform.position.y, 0);
            return;
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
