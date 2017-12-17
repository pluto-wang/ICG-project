# Interactive Computer Graphics Project <br/> Colorful Your Nails

## Motivation
市面上目前有許多的 free app，能夠提供套用彩妝效果美化相片，透過這樣的方式，不必真的在臉上塗塗抹抹就能夠得到漂亮的妝容，或者是風趣十足的特殊效果。但對於指甲彩繪方面的 APP，卻非常的稀少。現有關於指甲彩繪的 APP，多數為彩繪遊戲或者會請使用者對準畫面上指定好的手勢輪廓，拍攝照片之後再將指甲效果套用上去，而我們希望使用者可以動態的看到自己的手指貼上了指甲片之後的效果，為了達到期望的效果，我們選擇使用 AR 來實現我們的想法。


## Method and Elements
- Environment 
1) Vuforia <br/>
高通公司提供的免費 AR 平台，除了提供iOS, android 版本 SDK以外，也提供 unity 支援 <br/>
2) Unity <br/>
跨平台開發軟件可搭配 vuforia 進行 AR 程式開發之後，並輸出 iOS project 或 android APK 安裝於手機上執行 <br/>
3) Sculptris <br/>
由 pixologic 廠商所開發，唯一款免費的 3D 雕塑軟體 <br/>

- Method 
1) 使用sculptris 建立指甲模型，透過紙黏土雕刻方式，可以做出不同外觀的指甲 model，切換成 painting 模式之後再輸出 obj 檔案 <br/>
2) 將 obj 檔案匯入 Unity，並利用unity 的光源進行打光，讓指甲呈現光影的效果，撰寫切換指甲形狀、色彩及處理 texture 的 script，最後導出至手機平台 </br>
3) Vuforia AR marker， 指甲的範圍非常小，因此必須尋找小型的marker 來進行製作 <br/>

## Operation

## Future Work
- Markless <br/>
後續將再行研究如何將此作品轉換成 markerless，透過偵測手指輪廓之後並以指尖為定點顯示指甲，不再依賴 marker

- UI/UX <br/>
加強 UI/UX 的美觀與優化

- Custom painting mode <br/>
未來考慮加入painting 的功能，讓user 可以自己彩繪設計指甲色彩

## Referernce
[1] Vuforia official website: https://developer.vuforia.com/ <br/>
[2] Sculptris official website: http://pixologic.com/sculptris/ <br/>
[3] Handy AR: Markerless Inspection of Augmented Reality Objects Using Fingertip Tracking <br/>
[4] Fingernail detection in hand images using difference of nail-color pixels' density between <br/> vicinity areas of fingernails and skin 
[5] Fingernail image registration using Active Appearance Models <br/>
[6] Hand Tracking and Recognition With OpenCV <br/>
[7] ARToolKit Marker Generator <br/>
[8] OpenCV for Android, iOS <br/>

