using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening; //dotween kullanmak için kütüphane dahil ediyoruz.

public class menuController : MonoBehaviour
{
    public Transform playButton;
    public Transform logo;
    public Transform settings;
    public Transform levelSelectPanel;

    // Start is called before the first frame update
    void Start()
    {
        levelSelectPanel.gameObject.SetActive(false);
        levelSelectPanel.localScale = Vector3.zero;

        playButton.DOScale(1.1f, 1f).SetLoops(-1, LoopType.Yoyo);
        logo.DOLocalMoveY(299f, 1f);
       // settings.DOLocalMoveY(360f, 1f);

        logo.DORotate(new Vector3 (0, 0, 4), 1f).SetLoops(-1, LoopType.Yoyo);
      //  settings.DORotate(new Vector3(360, 0, 0), 2, RotateMode.FastBeyond360).SetEase(Ease.Linear);
    }

    public void playButtonClick()
    {
        levelSelectPanel.gameObject.SetActive(true);
        levelSelectPanel.DOScale(Vector3.one, .7f).SetEase(Ease.OutBounce).SetUpdate(true);
        // setupda timescale 0 iken de calisir.
    }

    public void selectPanelBack()
    {
        levelSelectPanel.DOScale(Vector3.zero, .7f).SetEase(Ease.InBounce).OnComplete(()=> {
            levelSelectPanel.gameObject.SetActive(false);
        });
    }

    // Update is called once per frame
    void Update()
    {
        settings.Rotate(0,0,2f);
    }
}
