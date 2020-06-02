using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBlocks : MonoBehaviour
{
    public GameObject block, allCubes, diamond;
    private GameObject blockInst;
    private Vector3 blockPos;
    private float speed = 7f;
    private bool onPlace;

    void Start()
    {
        spawn();
    }
    void Update()
    {
        if (blockInst.transform.position != blockPos && !onPlace)
            blockInst.transform.position = Vector3.MoveTowards(blockInst.transform.position, blockPos, Time.deltaTime * speed);
        else if (blockInst.transform.position == blockPos)
            onPlace = true;

        if(CubeJump.jump && CubeJump.nextBlock)
        {
            spawn();
            onPlace = false;
        }

    }

    float RandScale()
    {
        float rand;
        if (Random.Range(0, 100) > 80)
            rand = Random.Range(1.2f, 2f);
        else
            rand = Random.Range(1.2f, 1.5f);
        return rand;
    }
    void spawn()
    {

        blockPos = new Vector3(Random.Range(0.7f, 1.7f), -Random.Range(0.6f, 3.2f), 0f);
        blockInst = Instantiate(block, new Vector3(5f, -6f, 0f), Quaternion.identity) as GameObject;
        blockInst.transform.localScale = new Vector3(RandScale(), blockInst.transform.localScale.y, blockInst.transform.localScale.z);
        blockInst.transform.parent = allCubes.transform;

        if (CubeJump.count_blocks % 8 == 0 && CubeJump.count_blocks !=0)
        {
          GameObject diamondInst =  Instantiate(diamond, new Vector3(blockInst.transform.position.x, blockInst.transform.position.y + 0.5f, blockInst.transform.position.z), Quaternion.Euler(Camera.main.transform.eulerAngles)) as GameObject;
            diamondInst.transform.parent = blockInst.transform;
        }
    }
}
