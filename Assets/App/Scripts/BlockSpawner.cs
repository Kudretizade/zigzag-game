using UnityEngine;
public class BlockSpawner : MonoBehaviour
{
    [SerializeField] private GameObject TNTBlock;
    private int randomer;
    private Vector3 zort;
    private float x=0,z=0;
    private void Start() {
        for (int i = 0; i <= 30; i++)
        {
            spawnTNTBlock();
        }
    }
    private void spawnTNTBlock()
    {
        randomer = Random.Range(1,3);
            if (randomer == 1)
            {
                zort = new Vector3(x,0,z);
                x+=2.5f;
            }
            else if(randomer == 2)
            {
                zort = new Vector3(x,0,z);
                z+=2.5f;
            }
            Instantiate(TNTBlock,zort,transform.rotation);
    }
}