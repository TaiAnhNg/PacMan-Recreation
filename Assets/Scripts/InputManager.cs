using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private Tweener tweener;
    private Vector3 destination;
    private const float moveWait = 2f;
    public Animator pacControl;
    [SerializeField]
    private GameObject[] gameOs;
    // Start is called before the first frame update
    void Start()
    {
        tweener = GetComponent<Tweener>();
        InvokeRepeating("MoveTarget", 0f, moveWait);
    }


    // Update is called once per frame
    void Update()
    {
        destination = gameOs[0].transform.position;
        tweener.AddTween(gameOs[2].transform, gameOs[2].transform.position, destination, 2f);
        Vector3 param = destination - gameOs[2].transform.position;
        pacControl.SetFloat("DirY", param.y);
        pacControl.SetFloat("DirX", param.x);

    }
        
    void MoveTarget()
    {
        int index = 0;
        if (gameOs[1].transform.position.x > gameOs[0].transform.position.x)
            index = 1;

        Vector3 tempPos = gameOs[index].transform.position;
        // Moving vertically
        if (gameOs[index].transform.position.y > gameOs[1 - index].transform.position.y)
        {
            gameOs[index].transform.position = new Vector3(gameOs[index].transform.position.x,
                                                            gameOs[1 - index].transform.position.y,
                                                            gameOs[index].transform.position.z);
            gameOs[1 - index].transform.position = new Vector3(gameOs[1 - index].transform.position.x,
                                                               tempPos.y,
                                                               gameOs[1 - index].transform.position.z);
        }

        // Moving horizontally
        else
        {
            gameOs[index].transform.position = new Vector3(gameOs[1 - index].transform.position.x,
                                                            gameOs[index].transform.position.y,
                                                           gameOs[index].transform.position.z);
            gameOs[1 - index].transform.position = new Vector3(tempPos.x,
                                                                gameOs[1 - index].transform.position.y,
                                                                gameOs[1 - index].transform.position.z);
        }
    }
}

