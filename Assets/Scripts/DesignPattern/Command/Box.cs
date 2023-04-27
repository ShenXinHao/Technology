using DG.Tweening;
using UnityEngine;

namespace DesignPattern.Command
{
    public class Box : MonoBehaviour
    {
        
        public void Jump(int dir)
        {
            var pos = transform.position + Vector3.forward * 10 * dir;
            transform.DOJump(pos, 10, 1, 1).SetEase(DG.Tweening.Ease.InCirc);
        }

     
    }
}