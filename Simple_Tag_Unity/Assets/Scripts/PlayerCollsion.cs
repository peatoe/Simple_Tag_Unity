using UnityEngine;

public class PlayerCollsion : MonoBehaviour{

    [SerializeField] private Material myMaterial;
    public Color BaseColor;
    public bool isIt;

    // Start is called before the first frame update
    void OnCollisionEnter(Collision collisionInfo)
    {

       if (collisionInfo.collider.tag == "Player 1")
       {
            Debug.Log("Player 1");

            if(isIt){
               myMaterial.color = BaseColor;
               isIt = false;
            }
            else{
               isIt = true;
               myMaterial.color = Color.green;
            }
            
       }
       else if (collisionInfo.collider.tag == "Player 2")
       {
            Debug.Log("Player 2");

            
            if(isIt){
               myMaterial.color = BaseColor;
               isIt = false;
            }
            else{
               isIt = true;
               myMaterial.color = Color.green;
            }
       }
    }

//     void OnCollisionExit(Collision collisionInfo){
//      if(myMaterial.color == Color.green){
//           myMaterial.color = Color.red;
//      }
//     }
}