using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class Card : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    public Sprite activeImage; // アクティブ時のイメージ
    public Sprite inactiveImage; // 非アクティブ時のイメージ
    public Image imageComponent; // イメージを表示するUIコンポーネント
    public Image targetImage;
    private bool sta = true;
    public Transform defaultParent;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject parentObject = transform.parent.gameObject;

        // 親オブジェクトが存在するかチェック
        if (parentObject.name =="Gage" )
        {
            imageComponent.sprite = inactiveImage;
            transform.rotation = Quaternion.Euler(0f, 0f, 90f);
           
         
        }
        else if(parentObject.name == "Deck")
        {
            imageComponent.sprite = inactiveImage;
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
           


        }
        else if (parentObject.name=="Hand"|| parentObject.name == "You")
        {
            imageComponent.sprite = activeImage;
           
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);

        }
        else if (!sta &&(parentObject.name == "Left" || parentObject.name == "Right" || parentObject.name == "Center" || parentObject.name == "Flag")) 
        {
            
            transform.rotation = Quaternion.Euler(0f, 0f, 90f);


        }
        else
        {
          
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            imageComponent.sprite = activeImage;
            
        }
        

    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        
        defaultParent = transform.parent;
        transform.SetParent(defaultParent.parent, false);
        GetComponent<CanvasGroup>().blocksRaycasts = false;
        
        
    }
    // IDragHandler インターフェースの実装
    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;

    }
    public void OnEndDrag(PointerEventData eventData)
    {
        transform.SetParent(defaultParent, false);
        GetComponent<CanvasGroup>().blocksRaycasts = true;
        GameObject parentObject = transform.parent.gameObject;

        Debug.Log(parentObject.name);
        if (parentObject.name == "Left" || parentObject.name == "Right" || parentObject.name == "Center" 
            || parentObject.name == "Flag"|| parentObject.name == "Installation"||
            parentObject.name =="Cast"|| parentObject.name =="Drop")
        {
            Image otherObject = GameObject.Find("Big").GetComponent<Image>();
            otherObject.sprite = activeImage;
        }
    }
   
    
    /// 攻撃処理（保留）カード自体に攻撃機能をつける 。HorizontalRayoutGroupのせいで動かない
    
    public void Attack()
    {
        
        GameObject parentObject = transform.parent.gameObject;
        Debug.Log(parentObject.name);
        if (parentObject.name=="Left"|| parentObject.name == "Right"|| parentObject.name == "Center"|| parentObject.name == "Flag")
        {
            if (sta)
            {

                Image otherObject = GameObject.Find("Big").GetComponent<Image>();
                otherObject.sprite = activeImage;
                Debug.Log("2");
                sta = false;
            }
            else
            {
                sta = true;

            }

            
        }
        
    }
}
