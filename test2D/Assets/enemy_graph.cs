using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;
public class enemy_graph : MonoBehaviour
{
    public AIPath aipath;

    // Update is called once per frame
    void Update()
    {
        if(aipath.desiredVelocity.x>=0.01f)
        {
            transform.localScale = new Vector3(-3f, 3f, 1f);
        }
        else if(aipath.desiredVelocity.x<=-0.01f)
        {
            transform.localScale = new Vector3(3f, 3f, 1f);
        }
    }
}
