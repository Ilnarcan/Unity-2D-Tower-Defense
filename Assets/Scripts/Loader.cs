using UnityEngine;
using System.Collections;

public class Loader : MonoBehaviour {

    //public GameObject gameManager;

    void Awake() {

        //if (GameManager.instance == null)
        //    Instantiate(gameManager);

        KeyValue<int, string> course = new KeyValue<int, string>(666, "God");
        course.Print();

    }

    public void printAny<T>(T value) {
        Debug.Log("Value: " + value.ToString());
    }

    public class KeyValue<TKey, TValue> {
        private TKey key;
        private TValue value;

        public KeyValue(TKey _key, TValue _value) {
            key = _key;
            value = _value;
        }

        public void Print() {
            Debug.Log("Key: " + key.ToString());
            Debug.Log("Value: " + value.ToString());
        }

    }
}
