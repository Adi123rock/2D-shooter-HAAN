using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float backgroundspeed ;
    private float offset;
    private Material material;
    public float remainingtime =1.5f;
    bool fastmovingactivated= false;
    public void fastmoving() {
        fastmovingactivated = true;
        remainingtime = 1.5f;
        backgroundspeed = 10f ;
    }

    void Start()
    {
        material = GetComponent<Renderer>().material ;
        fastmoving();
    }

    void Update()
    {
        offset += (Time.deltaTime * backgroundspeed / 10f) ;
        material.SetTextureOffset("_MainTex", new Vector2(0,offset)) ;
        remainingtime = remainingtime - Time.deltaTime ;
        if(fastmovingactivated = true && remainingtime <0){
            fastmovingactivated = false ;
            backgroundspeed = 1f ;
        }
    }
}
