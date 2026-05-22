using UnityEngine;
using RootMotion.FinalIK;

public class HeadNod : MonoBehaviour
{
    public FBBIKHeadEffector headEffector;       // Reference to the FBBIK component
    public float nodSpeed = 10f;      // Speed of the nodding motion
    public float nodAngle = 5f;     // Maximum angle of the nod


    private float nodTimer = 0f;
    private bool isNodding = false;

    void Update()
    {

        if (isNodding)
        {
            NodHead();
        }
    }

    public void StartNod()
    {
        if (!isNodding)
        {
            isNodding = true;
            nodTimer = 0f;
        }
    }

    private void NodHead()
    {
        // Calculate the nodding motion (sine wave to nod up and down)
        nodTimer += Time.deltaTime * nodSpeed;
        float nod = Mathf.Sin(nodTimer) * nodAngle;


        headEffector.transform.localEulerAngles = new Vector3(0, 0, nod);

        if (nodTimer > Mathf.PI * 2f)
        {
            // Stop nodding after one cycle
            isNodding = false;
            nodTimer = 0f;
        }
    }
}
