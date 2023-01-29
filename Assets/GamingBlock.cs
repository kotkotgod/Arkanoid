using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamingBlock : MonoBehaviour 
{
    Block block;
    Transform t;
    
    private void Start()
    {
        block = new Block(1);
    }

    private void Update()
    {
       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        int h = block.GetHit();
        if (h == 0)
        {
            //death thingy
            Destroy(gameObject);
        }
        else
        {
            Debug.Log($"Â ÌÈÍÅ ÂÁÈÂÑß ØÀÐÈÊ, îñòàëîñÿ {h} çäîðîâüÿ");
            //draw particles, play a sound, change color or something
        }
    }

}

public class Block
{
    int health;

    public Block(int i) => health = i;
    public Block() => new Block(1);

    public int GetHit()
    {
        health -= 1;
        return health;
    }


}
