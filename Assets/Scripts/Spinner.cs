using UnityEngine;

public class Spinner : MonoBehaviour
{
    private Vector3 baseScale;
    [SerializeField] int pulseSpeed = 3;
    [SerializeField] float pulseAmount = 0.2f ;
    [SerializeField] int degreesPerSecond = 90;

    void Start()
    {
        baseScale = transform.localScale;
    }

    
    void Update()
    {

        transform.Rotate(0f, degreesPerSecond * Time.deltaTime, 0f, Space.World);
        float s = 1f + pulseAmount * Mathf.Sin(Time.time * pulseSpeed);
        transform.localScale = baseScale*s;
    }
}
