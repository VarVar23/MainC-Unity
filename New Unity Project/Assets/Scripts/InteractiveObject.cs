using UnityEngine;

namespace Game
{
    public abstract class InteractiveObject : MonoBehaviour, IInteractable, IInitialization
    {
        public bool IsInteractable { get; } = true;
        protected abstract void Interaction();

        private void OnTriggerEnter(Collider other)
        {
            if (IsInteractable || other.CompareTag("Player"))
            {
                Interaction();
                Destroy(gameObject);
            }
        }


        private void Start()
        {
            ((IInteractable)this).Action();
        }

        public void Action()
        {
            if (TryGetComponent(out Renderer renderer))
            {
                renderer.material.color = Random.ColorHSV();
            }
        }
    }

}
