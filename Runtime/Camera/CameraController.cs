using UnityEngine;

namespace BilliotGames
{
    public class CameraController : MonoBehaviour
    {
        [SerializeField] Transform followTarget;
        [SerializeField] Vector3 offest;

        public void CalculateOffset() {
            if (followTarget != null) {
                offest = transform.position - followTarget.position;
            }
        }

        private void LateUpdate() {
            transform.position = offest + followTarget.position;
        }
    }
}
