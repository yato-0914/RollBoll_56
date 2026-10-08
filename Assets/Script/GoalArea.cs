using UnityEngine;

public class GoalArea : MonoBehaviour
{
    [SerializeField]private GameObject canvasObject;
    private void OnTriggerEnter(Collider other)
    {
       
            canvasObject.SetActive(true);
      if(other.tag == "Player")
            
      {
            Destroy(other.gameObject);
            Debug.Log("ÉSÅ[ÉãÇµÇΩ");
       }
    }
   
}
