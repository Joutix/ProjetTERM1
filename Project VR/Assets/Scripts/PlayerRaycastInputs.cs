using UnityEngine;

public class PlayerRaycastInputs : MonoBehaviour
{
    public LayerMask layerMask;
    public InteractibleObject lastHitObject;

    // Update is called once per frame
    void Update()
    {
        InteractibleObject obj=null;
        RaycastHit hit;
        Transform camTrasnform = Camera.main.transform;
        if (Physics.Raycast(camTrasnform.position,camTrasnform.forward, out hit, Mathf.Infinity, layerMask.value))
        {
            Collider coll = hit.collider as Collider;
            if (coll != null)
            {

               obj = coll.GetComponent<InteractibleObject>();
                if (obj != null)
                {
                    obj.Select();
                    
                }
            }
        }
        if (lastHitObject != null && lastHitObject != obj) lastHitObject.UnSelect();
        lastHitObject = obj;
    }
}
