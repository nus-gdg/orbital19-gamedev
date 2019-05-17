using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxBackgroundV4 : MonoBehaviour
{
    public List<SpriteRenderer> Backgrounds;
    public List<float> Distances;
    public float DepthToGround = 1;

    private MaterialPropertyBlock propBlock;
    private List<float> bgDistances;

    private float distanceTravelled = 0;

    private void Start()
    {
        float groundDistance = Backgrounds[0].sprite.bounds.extents.x * 2;
        propBlock = new MaterialPropertyBlock();
        bgDistances = new List<float>(new float[Distances.Count]);
        for (int i = 0; i < Backgrounds.Count; ++i)
        {
            float distanceToBackground = Distances[i];
            bgDistances[i] = groundDistance * (DepthToGround + distanceToBackground) / DepthToGround;
        }
    }

    private void Update()
    {
        distanceTravelled += Time.deltaTime * CactusObstacleV4.Speed;

        for (int i = 0; i < Backgrounds.Count; ++i)
        {
            Renderer bgRenderer = Backgrounds[i];
            float bgDistance = bgDistances[i];
            bgRenderer.GetPropertyBlock(propBlock);
            propBlock.SetFloat("_Offset", distanceTravelled / bgDistance);
            bgRenderer.SetPropertyBlock(propBlock);
        }
    }
}
