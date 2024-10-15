using UnityEngine;

public class ChangeCubeColor : MonoBehaviour
{
    private Renderer cubeRenderer;
    void Start()
    {
        cubeRenderer = GetComponent<Renderer>();

        cubeRenderer.material.color = Color.red;
    }
}
