using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
    public int rulesCount;
    public int[] rules;
    public LiftGernerationStrategy strategy;

    public Lift[] liftPerfs;
    [SerializeField] 
    public Dictionary<int, int> liftRule = new Dictionary<int, int>();

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
            floors[i].number = i+1;
            //floors[i].generateLifts();
            floors[i].transform.position = new Vector3(0, 0 - distaceBeetwenFloors*i, 0);
        }

        generateRules();
    }

    public void generateRules(){
        int m1 = Random.Range(1,size / 2);
        int m2 = -Random.Range(1,size / 2);
        while(!checkConection(m1,m2)){
            m1 =Random.Range(1,size / 2);
            m2 = -Random.Range(1,size / 2);
        }
        int m3 = Random.Range(-size,size);
        int m4 = Random.Range(-size,size);
        int m5 = Random.Range(-size,size);
        int m6 = Random.Range(-size,size);
        rules = new int[]{m1,m2,m3,m4,m5,m6};
        for(int i = 0;i<rules.Length;i++){
            liftRule[rules[i]] =i;
        }
        
    }

    private bool checkConection(int m1, int m2){
        HashSet<int> unreached = new HashSet<int>();
        Queue<int> q = new Queue<int>();
        for (int i = 1;i <= size;i++){
            unreached.Add(i);
        }

        q.Enqueue(1);
        while(q.Count != 0){
            int next = q.Dequeue();
            unreached.Remove(next);
            if (unreached.Contains(next + m1)){
                q.Enqueue(next + m1);
            }
            if (unreached.Contains(next + m2)){
                q.Enqueue(next + m2);
            }
        }
        return unreached.Count == 0;

    }
    public void attacheLifts(){
            HashSet<int> unreached = new HashSet<int>();
            List<int> reached = new List<int>{};
            for (int i = 1;i < size;i++){
                unreached.Add(i);
            }
            reached.Add(0);
            while((unreached.Count!=0)){
                int move = rules[Random.Range(0,rules.Length)];
                int randomFloor = reached[Random.Range(0,reached.Count)];
                if((randomFloor + move >= 0) && (randomFloor + move < size)){
                    if (floors[randomFloor].attachedTo(floors[randomFloor + move])){
                        if (unreached.Remove(randomFloor + move)){
                            reached.Add(randomFloor + move);
                        }
                    }
                }
            }

            for (int n =0;n < 10;n++){
                for (int i = 0;i<size;i++){
                    int move = rules[Random.Range(0,rules.Length)];
                    if((i + move >= 0) && (i + move < size)){
                        floors[i].attachedTo(floors[i + move]);
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
