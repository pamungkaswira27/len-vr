using UnityEngine;

public class SetupXRRig : MonoBehaviour
{
    [SerializeField] Transform _cameraOffset;

    void Start()
    {
        _cameraOffset.position = new Vector3(0f, 1.5f, 0f);
    }
}
