using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPPOV_Look : MonoBehaviour
{
    Vector2 mouseLook;
    Vector2 smoothLook;
    public float sensitivity = 5.0f;
    public float smoothing = 2.0f;

    GameObject avatar;

    void Start()
    {
        avatar = this.transform.parent.gameObject;
    }

    void Update()
    {
        var mouseDelta = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));
        mouseDelta = Vector2.Scale(mouseDelta, new Vector2(sensitivity * smoothing, sensitivity * smoothing));
        smoothLook.x = Mathf.Lerp(smoothLook.x, mouseDelta.x, 1f / smoothing);
        smoothLook.y = Mathf.Lerp(smoothLook.y, mouseDelta.y, 1f / smoothing);
        mouseLook += smoothLook;

        if (-mouseLook.y < 85 && -mouseLook.y > -85)
        { 
            transform.localRotation = Quaternion.AngleAxis(-mouseLook.y, Vector3.right);
        }
            avatar.transform.localRotation = Quaternion.AngleAxis(mouseLook.x, avatar.transform.up);

    }
}
