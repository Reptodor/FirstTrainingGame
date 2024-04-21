using System;
using UnityEngine;
using UnityEngine.UI;

public class WalletDisplay : MonoBehaviour
{
    [SerializeField] private Text _countOfCoinsText;
    [SerializeField] private Wallet _wallet;

    private void Start()
    {
        _countOfCoinsText.text = $"0/{_wallet.GetSizeOfWallet()}";
        
        _wallet.OnCountOfCoinsChanged.AddListener((CountOfCoins) =>
        {
            _countOfCoinsText.text = $"{CountOfCoins}/{_wallet.GetSizeOfWallet()}";
        });
    }
}
