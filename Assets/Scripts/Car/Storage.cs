using Assets.Scripts.Items;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Car
{
    internal class StoragePlace
    {
        internal Transform _place;
        internal IStorable _item;
        internal StoragePlace(Transform transform, IStorable item)
        {
            _place = transform;
            _item = item;
        }
        internal void InsertItem(IStorable item)
        {
            _item = item;
        }
        internal IStorable QueryItem()
        {
            IStorable item = _item;
            _item = null;
            return item;
        }
    }

    public class Storage : MonoBehaviour
    {
        [SerializeField] private List<Transform> _storagePlacesTransforms;

        private List<StoragePlace> _storagePlaces;

        private void Awake()
        {
            _storagePlaces = new List<StoragePlace>();
            foreach (var storagePlaceTransform in _storagePlacesTransforms)
            {
                _storagePlaces.Add(new StoragePlace(storagePlaceTransform, null));
            }
        }

        private void OnCollisionEnter(Collision collision)
        {
            if(collision.gameObject.TryGetComponent<IStorable>(out IStorable item))
            {
                Insert(item);
            }
        }

        private void OnCollisionExit(Collision collision)
        {
            if (collision.gameObject.TryGetComponent<IStorable>(out IStorable item))
            {
                Query(item);
            }
        }

        private void Insert(IStorable item)
        {
            foreach(var storagePlace in _storagePlaces)
            {
                if(storagePlace._item != null)
                {
                    storagePlace.InsertItem(item);
                    item.Store(storagePlace._place);
                    return;
                }
            }
        }

        private void Query(IStorable item)
        {
            foreach( var storagePlace in _storagePlaces)
            {
                if(item == storagePlace._item)
                {
                    storagePlace.QueryItem();

                }
            }
        }

    }
}
