using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Utils {
  public static Vector3 ComponentDivision (Vector3 a, Vector3 b) {
    return new Vector3(a.x / b.x, a.y / b.y, a.z / b.z);
  }
}
