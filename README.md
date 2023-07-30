# UnityLib

## 系統
1. FightSys
1. ObjectSys
1. 

## InputSys
獨體方法實作，將輸入的訊號轉成我們可以判斷行為的訊號。

## FightSys
用服務的方式注入，決定由簡單到複雜的戰鬥機至。

## ObjectSys
??：這要自己實作嗎？還是寫一個公版的，直接綁定 Unity。
1. Create
1. Destroy
1. 碰撞判定的邊界(方體概念)(圓形的概念)
    override (引入碰撞體)
 
## PhysicsSys
??：這要自己實作嗎？還是寫一個公版的，直接綁定 Unity。
1. 重力加速度
1. 物理碰撞

### 靜態方法

### 可串接功能
1. ICanMove
1. 

### 屢一屢思路

#### MonoBehavior 
  MonoBehavior的 Update執行。
  控制 Animator的變數決定播放 Animation的內容

 MonoBehavior 子類別繼承 狀態機，讓它用 switch 去決定怎麼傳播他的動作。

 位移也分為：程式位移 vs 美術位移，所以也要保留位移的實作。

