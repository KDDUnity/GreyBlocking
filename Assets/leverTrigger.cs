using UnityEngine;

public class leverTrigger : MonoBehaviour
{
    public GameObject leverToActivate;
    public GameObject leverToDeactivate;
    public Animator animator;
    bool LeverActivated = false;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !LeverActivated)
        {
            leverToActivate.SetActive(true);
            leverToDeactivate.SetActive(false);
            LeverActivated = true;
            animator.SetBool("LeverActivated", true);
        }
        
    }
}