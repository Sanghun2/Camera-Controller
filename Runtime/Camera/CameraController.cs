using UnityEngine;

namespace BilliotGames
{
    [RequireComponent(typeof(Camera))]
    public class CameraController : MonoBehaviour
    {
        [SerializeField] Transform followTarget;
        [SerializeField] Vector3 offest;

        public void CalculateOffsetBetweenTarget() {
            if (followTarget != null) {
                offest = transform.position - followTarget.position;
            }
        }

        private void LateUpdate() {
            transform.position = offest + followTarget.position;
        }
    }
}
