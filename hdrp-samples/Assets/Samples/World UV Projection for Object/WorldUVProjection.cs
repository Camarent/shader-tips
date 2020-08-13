using UnityEngine;

namespace Samples.World_UV_Projection_for_Object
{
    [RequireComponent(typeof(MeshRenderer))]
    [ExecuteInEditMode]
    public class WorldUVProjection : MonoBehaviour
    {
        private Material _material;
        private MeshRenderer _renderer;
        
        private static readonly int Scale = Shader.PropertyToID("_Scale");

        void Start()
        {
            _renderer = GetComponent<MeshRenderer>();
            _material = _renderer.sharedMaterial;
        }

        // Update is called once per frame
        void Update()
        {
            if (_material != null)
                _material.SetFloat(Scale, _renderer.bounds.extents.y);
        }
    }
}