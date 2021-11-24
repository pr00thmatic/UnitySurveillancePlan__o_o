using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[ExecuteInEditMode]
public class ScreenCameraSelector : MonoBehaviour {
  [Header("Configuration")]
  public Texture offline;

  [Header("Initialization")]
  public new MeshRenderer renderer;
  [SerializeField] new SurveillanceCamera camera;

  void OnEnable () {
    if (camera) {
      UpdateTexture();
      camera.onTextureChange += UpdateTexture;
    }
  }

  void OnDisable () {
    if (camera) camera.onTextureChange -= UpdateTexture;
  }

  #if UNITY_EDITOR
  void Update () {
    UpdateTexture();
  }
  #endif

  public void SetCamera (SurveillanceCamera camera) {
    this.camera = camera;
    UpdateTexture();
  }

  public void UpdateTexture () {
    if (camera) {
      renderer.sharedMaterial.SetTexture("_MainTex", camera.target);
    } else {
      renderer.sharedMaterial.SetTexture("_MainTex", offline);
    }
  }
}
