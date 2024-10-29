using UnityEngine;

namespace Assets.Scripts.Interactions
{
    public interface IDraggable
    {

        public void Drag();
        public void Drop();
        public void Dragging(Vector3 moveDir, float draggingSpeed);
    }
}
