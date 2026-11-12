using UnityEngine;

public class SpinnerScript : MonoBehaviour
{

    public float spinSpeed = 80f;


    void Update()

    {

        transform.Rotate(spinSpeed * Time.deltaTime, 0f, 0f);

    }

}