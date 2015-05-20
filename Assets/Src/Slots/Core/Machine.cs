using UnityEngine;
using System.Collections;
using HTTP;

namespace Slots {
  namespace Core {
    public class Machine : MonoBehaviour {
      void Start() {
        StartCoroutine(Get());
      }

      void Update() {
      }

      IEnumerator Get() {
        HTTP.Request someRequest = new HTTP.Request("get", "http://www.doubletapgames.biz/hwp/dev/poker/bridge/globalregistry");
        someRequest.Send();

        while (!someRequest.isDone) {
          yield return null;
        }

        Debug.Log(someRequest.response.Text);
      }
    }
  }
}