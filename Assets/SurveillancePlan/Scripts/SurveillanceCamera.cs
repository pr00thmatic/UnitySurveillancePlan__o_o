using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[ExecuteInEditMode]
public class SurveillanceCamera : MonoBehaviour {
  public event System.Action onTextureChange;

  [Header("Initialization")]
  public RenderTexture target;
  public new Camera camera;

  void OnEnable () {
    if (!target) {
      target = new RenderTexture(640, 360, 24, RenderTextureFormat.ARGB32);
      target.Create();
      camera = GetComponent<Camera>();
      camera.targetTexture = target;

      onTextureChange?.Invoke();
    }
  }

  void Update () {
    camera.targetTexture = target;
  }
}
