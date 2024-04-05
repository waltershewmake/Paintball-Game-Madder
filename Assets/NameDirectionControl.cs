using UnityEngine;

public class NameDirectionControl : MonoBehaviour
{
    public bool m_UseRelativeRotation = true;  


    private Quaternion m_RelativeRotation; 
    public Vector3 objectRotation;    


    private void Start()
    {
        Quaternion rotationQuaternion = Quaternion.Euler(objectRotation);
        transform.localRotation = rotationQuaternion;
        m_RelativeRotation = transform.parent.localRotation;
    }


    private void Update()
    {
        if (m_UseRelativeRotation)
        {
            Quaternion rotationQuaternion = Quaternion.Euler(objectRotation);
            transform.rotation = m_RelativeRotation * rotationQuaternion;
        }
    }
}
