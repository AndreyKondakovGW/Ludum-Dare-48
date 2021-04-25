using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public int sectionSize = 20;
    public int currentFloor = 1;
    public Section sectionPerf;
    public Section currensection;
    public Floor floorPerf;


    void generateNewSection()
    {
        currensection = Instantiate(sectionPerf);
        currensection.setPropertice(sectionSize, "Section A");
        currensection.transform.position = new Vector3(0, 0, 0);
        currensection.GenerateFloors();
        currensection.attacheLifts();
    }

    // Start is called before the first frame update
    void Start()
    {
        generateNewSection();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
