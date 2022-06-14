using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainTemplateGenerator : MonoBehaviour
{
    [Header("Templates")]
    public List<TerrainTemplateGenerator> terrainTemplates;
    public float terrainTemplateWidth;
    [Header("Generator Area")]
    public Camera mainCamera;
    public float areaStartOffset;
    public float areaEndOffset;

    private const float debugLineHeight = 10.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    private float GetHorizontalPositionStart()
    {
        return mainCamera.ViewportToWorldPoint(new Vector2(0f, 0f)).x + areaStartOffset;
    }

    private float GetHorizontalPositionEnd()
    {
        return mainCamera.ViewportToWorldPoint(new Vector2(1f, 0f)).x + areaEndOffset;
    }

    private void OnDrawGizmos()
    {
        Vector3 areaStartPosition = transform.position;
        Vector3 areaEndPosition = transform.position;
        areaStartPosition.x = GetHorizontalPositionStart();
        areaEndPosition.x = GetHorizontalPositionEnd();
        Debug.DrawLine(areaStartPosition + Vector3.up * debugLineHeight / 2, areaStartPosition + Vector3.down * debugLineHeight / 2, Color.red);
        Debug.DrawLine(areaEndPosition + Vector3.up * debugLineHeight / 2, areaEndPosition + Vector3.down * debugLineHeight / 2, Color.red);
    }
   

    // Update is called once per frame
    void Update()
    {
        
    }
}
