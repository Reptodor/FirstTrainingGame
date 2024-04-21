using UnityEngine;
using UnityEngine.Events;

public class Wallet : MonoBehaviour
{
    [SerializeField] private Finish _finish;
    [SerializeField] private int _size = 3;
    private int _currentCoinsCount = 0;

    public UnityEvent<int> OnCountOfCoinsChanged;

    public int GetSizeOfWallet()
    {
        return _size;
    }
    
    public void AddCoin(int coin)
    {
        if (_currentCoinsCount + coin <= _size)
        {
            _currentCoinsCount += coin;
            
            if(_currentCoinsCount == _size)
            {
                _finish.CanFinish = true;
            }
            
            OnCountOfCoinsChanged.Invoke(_currentCoinsCount);
        }
    }
}
