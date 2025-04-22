using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolPath : MonoBehaviour
{
    //public Transform waypoint1;
    //public Transform waypoint2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public int GetNextIndex (int i)
        {
            if (i + 1 == transform.childCount)
            {
                return 0;
            }
            return i + 1;
        }

       public Vector3 GetWaypoint(int i)
        {
            return transform.GetChild(i).position;
        }
}
