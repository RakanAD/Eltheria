using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stone : MonoBehaviour
{
    public Route currentRoute;

    int routePosition;

    public int steps;

    bool isMoving;

    public void mouvement()
    {
        steps = Random.Range(1, 4);
        Debug.Log("Dice Rolled " + steps);
        StartCoroutine(Move());
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) && !isMoving)
        {
            mouvement();
        }
    }
    
    IEnumerator Move()
    {
        if (isMoving)
        {
            yield break;
        }
        isMoving = true;

        while (steps > 0)
        {
          
            routePosition++;
            routePosition %= currentRoute.childNodeList.Count;
          
            Vector3 nextPos = currentRoute.childNodeList[routePosition].position;
            while (MoveToNextNode(nextPos)) { yield return null; }

            yield return new WaitForSeconds(0.1f);
            steps--;
        }

        isMoving = false;
    }

    bool MoveToNextNode(Vector3 goal)
    {
        return goal != (transform.position = Vector3.MoveTowards(transform.position, goal, 6f * Time.deltaTime));
    }
}
