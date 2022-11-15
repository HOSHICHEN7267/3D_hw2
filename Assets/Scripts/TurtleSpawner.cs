using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtleSpawner : MonoBehaviour
{

    public GameObject TurtlePrefab;

    float sideLen = 7.2f;
    float gridLen = 1.6f;
    float halfGridLen = 0.8f;
    float gridDis = 0.7f;

    float time = 0f;
    // float destroyTime = 3f;
    float periodTime = 2.5f;

    bool firstSpawn = true;

    // Start is called before the first frame update
    void Start()
    {
        time = 0f;
        gridLen = sideLen / 5;
        halfGridLen = gridLen / 2;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (time > periodTime || firstSpawn)
        {
            firstSpawn = false;

            float posx = 0f;
            float posz = 0f;
            float roty = 0f;

            int posNum = Random.Range(0, 19);
            Debug.Log("pos: " + posNum);
            if (posNum <= 4)
            {
                posx = (posNum - 2) * gridLen;
                posz = halfGridLen + gridLen * 2 + gridDis;
                roty = 180f;
            }
            else if (posNum <= 9)
            {
                posx = halfGridLen + gridLen * 2 + gridDis;
                posz = -1 * (posNum - 7) * gridLen;
                roty = -90f;
            }
            else if (posNum <= 14)
            {
                posx = -1 * (posNum - 12) * gridLen;
                posz = -1 * (halfGridLen + gridLen * 2 + gridDis);
                roty = 0f;
            }
            else if (posNum <= 19)
            {
                posx = -1 * (halfGridLen + gridLen * 2 + gridDis);
                posz = (posNum - 17) * gridLen;
                roty = 90f;
            }

            Quaternion newRotation = Quaternion.Euler(0, roty, 0);
            Instantiate(TurtlePrefab, new Vector3(posx, 0, posz), newRotation);

            time = 0;
        }
    }
}
