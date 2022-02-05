# DomasniVr 1 i 2
1. Изворниот код е фолдерот лаб01.
2.Апликацијата е тестирана на Samsung Note4. Тоа може да го видиме и на видеото.
Линк до извршна верзија ( https://github.com/Icko9/DomasniVr/blob/main/lab01/v01.apk )

3. Линк до видеото:
 https://github.com/Icko9/DomasniVr/blob/main/video.mp4

4.Образложение: 

Апликацијата е едноставна, изработена е во unity , нема никакво мени за навигација само ја стартуваме апликацијата и автоматски карактерот започнува да се движи , бидејќи не му ставив гравитација (целата идеја е да биде дух) , може да се движи во слободен лет , односно да поминува низ објекти да оди горе , доле , лево ,десно зависно од насоката во која е свртен телефонот односно позицијата на ротација.
Ова е постигнато со едноставна скрипта PlayerWalk.cs, во скриптата имаме само една променлива односно брзината со која се движиме. Во функцијата Update() всушност ја менуваме позицијата со помош на формулата: 
  **transform.position + Camera.main.transform.forward * playerSpeed * Time.deltaTime;**  
Околината ја изградив со помош на следниов пакет од модели:

https://assetstore.unity.com/packages/3d/environments/3d-low-poly-village-164241

Користена литература :
Plugin za google vr SDK

https://github.com/googlevr/gvr-unity-sdk/releases

Видео со инструкции:

https://www.youtube.com/watch?v=qZzhXHqXM-g&t=10s&ab_channel=Valem


![alt text](https://github.com/Icko9/DomasniVr/blob/main/ScreenShots/slika1.png)
![alt text](https://github.com/Icko9/DomasniVr/blob/main/ScreenShots/slika2.png)
![alt text](https://github.com/Icko9/DomasniVr/blob/main/ScreenShots/slika%203.png)
![alt text](https://github.com/Icko9/DomasniVr/blob/main/ScreenShots/slika%204.png)
![alt text](https://github.com/Icko9/DomasniVr/blob/main/ScreenShots/slika%205.png)
![alt text](https://github.com/Icko9/DomasniVr/blob/main/ScreenShots/slika%206.png)
![alt text](https://github.com/Icko9/DomasniVr/blob/main/ScreenShots/slika%207.png)

  
