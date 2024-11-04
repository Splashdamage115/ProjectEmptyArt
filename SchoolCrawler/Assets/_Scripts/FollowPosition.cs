using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class FollowPosition : MonoBehaviour
{
    [Header("Follow Properties")]
    public Transform FollowTarget;
    private Transform objPosition;

    [Header("Follow Options")]
    [SerializeField]
    private float speed;
    [SerializeField]
    private float stopFollowRadius;
    private float speedMultiplier;
    [SerializeField]
    private float maxMultiplier;

    void Start()
    {
        objPosition = GetComponent<Transform>();
    }

    void FixedUpdate()
    {
        Vector2 follow = new Vector2(FollowTarget.position.x, FollowTarget.position.y);
        Vector2 obj = new Vector2(objPosition.position.x, objPosition.position.y);
        float distance = math.distance(follow, obj);
        if (distance >= stopFollowRadius)
        {
            speedMultiplier = distance;
            speedMultiplier = Mathf.Clamp(speedMultiplier, 1.0f, maxMultiplier);
            Vector2 lerp = Vector2.Lerp(obj, follow, speed * speedMultiplier * Time.fixedDeltaTime);
            objPosition.position = new Vector3(lerp.x, lerp.y, objPosition.position.z);
        }
    }
}
