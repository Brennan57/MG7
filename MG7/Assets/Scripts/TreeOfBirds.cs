using UnityEngine;

// Step 1: write the TreeOfBirds class in this file!
public class TreeOfBirds : MonoBehaviour
{
    public Bird[] sparrows = new Bird[4];
    public float interdis;
    public GameObject player;

    void Start()
    {

        sparrows = GetComponentsInChildren<Bird>(true);
        /*
            for(int i=0; i<sparrows.Length; i++){
                if(sparrows[i].gameObject.tag=="spar"){
                    sparrows[i].gameObject.SetActive(false);
            }
        }
        */
        
    }

    private void Update(){
        
        for(int i=0; i<4; i++)
            {
                if(Vector3.Distance(sparrows[i].transform.position, player.transform.position)<interdis){
                    sparrows[i].gameObject.SetActive(true);
                }
            }
        }
}

