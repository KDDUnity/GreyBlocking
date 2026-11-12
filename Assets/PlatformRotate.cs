using UnityEngine;

public class PlatformRotate : MonoBehaviour
{
    public GameObject leverToActivate;
    public GameObject leverToDeactivate;
    public Animator animator;
    bool PlatformSwitch = false;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !PlatformSwitch)
        {
            leverToActivate.SetActive(true);
            leverToDeactivate.SetActive(false);
            PlatformSwitch = true;
            animator.SetBool("PlatformSwitch", true);
        }

    }
}