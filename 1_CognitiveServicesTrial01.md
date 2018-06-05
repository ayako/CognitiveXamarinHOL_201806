# Azure Cognitive Services を活用した Xamarin によるマルチプラットフォームアプリ開発 ハンズオン

## 1. “人工知能パーツ” Cognitive Services 概要 & はじめて触ってみるハンズオン

このセクションでは Azure Cognitive Services を利用したデモサイトに触れ、Cognitive Services の 各 API の動作を確認します。  

### 1-1. Cognitive Services の動作をデモサイトで確認する

Cognitive Services の各 API 詳細画面には、デモが用意されており、サブスクリプション 申込なしで動作を確認できます。 以下の手順でいくつかの API の動作を確認します。  

1. ブラウザーで [Cognitive Services の Web サイト](https://azure.microsoft.com/ja-jp/services/cognitive-services/) (<http://microsoft.com/cognitive>) を開きます。こちらのサイトでは、Cognitive Services の 5 つの API グループ別 (視覚、音声、知識、言語、検索) に説明が書かれています。  

<img src="media/CognitiveXamarinHOL_201806_01.PNG" width="450" height="291">  

2. **視覚** をクリックします。**視覚** のページ内には、Computer Vision など 画像・動画の分析をおこなう API が表示されています。  

<img src="media/CognitiveXamarinHOL_201806_02.PNG" width="450" height="291">  

#### Computer Vision API

3. **Computer Vision** をクリックして開きます。Computer Vision の下記の機能およびデモが用意されています。

    - 画像の分析によるタグ付け、キャプション生成、顔検出、カラー抽出
    - OCR (画像からの文字認識 : 手書き文字含む)
    - 著名人およびランドマークの検出
    - サムネイル作成  

<img src="media/CognitiveXamarinHOL_201806_03.PNG" width="450" height="291">  

4. **画像の分析** デモサイトで、画像をクリック、またはお手持ちの画像をアップロードして、人間の顔の認識とその分析、画像の説明やその他の分析内容が表示されることを確認してください。  

<img src="media/CognitiveXamarinHOL_201806_04.PNG" width="450" height="291">  

5. ブラウザーのバック (←) ボタンでひとつ前のページ (**視覚** グループのページ) に戻ります。  

#### Face API

6. 今度は **Face** をクリックして開きます。Face の下記の機能およびデモが用意されています。 

    - 顔検出 : 画像内の顔の位置、顔属性 (年齢、性別、感情、眼鏡や髭、髪の色など) 
    - 顔識別、似た顔の検索、グループ化  

<img src="media/CognitiveXamarinHOL_201806_05.PNG" width="450" height="291">  

7. 画面をスクロールします。**顔検出** のデモサイトで、画像をクリック、またはお手持ち の画像をアップロードして、人間の顔の認識と、年齢や性別、表情など顔情報の分析内容が表示されることを確認してください。  

<img src="media/CognitiveXamarinHOL_201806_06.PNG" width="450" height="291">  

8. ブラウザーのバック (←) ボタンでひとつ前のページ (**視覚** グループのページ) に戻ります。  

> 画像の分析結果は、画像の右枠に表示されるように JSON 形式で返されます。他の API でも同様に、決まった形式の JSON で結果を取得できます。
  

#### Video Indexer

9. **Video Indexer** をクリックして開きます。Video Indexer はアップロードされた動画を分析し、登場する人物、発話内容の分析を行い、翻訳して一般公開可能なプラットフォームです。**はじめる** をクリックして、デモサイトを開きます。  

<img src="media/CognitiveXamarinHOL_201806_07.PNG" width="450" height="291">  

10. Video Indexer の Web サイトで **サインイン** をクリックしてサインインします。  

<img src="media/CognitiveXamarinHOL_201806_08.PNG" width="450" height="291">  

11. **Live または Outlook アカウントでサインイン** を選択し、マイクロソフトアカウントでサインインします。  

<img src="media/CognitiveXamarinHOL_201806_09.PNG" width="450" height="291">  

12. アプリ アクセス許可の画面が表示されたら、[はい] をクリックして進みます。  

<img src="media/CognitiveXamarinHOL_201806_10.PNG" width="450" height="291">  

13. Video Indexer の画面で、**サンプル ビデオ** タブをクリックします。表示されているビデオのうち、いずれかをクリックします。  

<img src="media/CognitiveXamarinHOL_201806_11.PNG" width="450" height="291">  

14. ビデオ再生画面の右側に、ビデオ分析結果が表示されることを確認してください。**分析情報** タブには、登場する人物とビデオの登場箇所、発言キーワード、タグ、発話の感情などが表示されます。  

<img src="media/CognitiveXamarinHOL_201806_12.PNG" width="450" height="291">  

15. **トランスクリプト** タブをクリックすると、発話内容がテキスト表示されます。言語のドロップダウンリストを操作すると、翻訳されて表示されることを確認してください。  

<img src="media/CognitiveXamarinHOL_201806_13.PNG" width="450" height="291">  

16.  [Cognitive Services の Web サイト](https://azure.microsoft.com/ja-jp/services/cognitive-services/) (<http://microsoft.com/cognitive>) に戻ります。  
  

#### Text Analytics API

17. Cognitive Services の Web サイトで **言語** をクリックします。   

<img src="media/CognitiveXamarinHOL_201806_01.PNG" width="450" height="291">  

18. **言語** のページ内には、自然言語を分析する API 群が表示されています。**Text Analytics** をクリックします。  

<img src="media/CognitiveXamarinHOL_201806_14.PNG" width="450" height="291">  

19.  Text Analytics API は、文章の言語、キーワード、センチメント (感情) を分析します。 デモ画面で、サンプル文章 または 自由に文章を入力して、分析結果を確認してください。  

<img src="media/CognitiveXamarinHOL_201806_15.PNG" width="450" height="291">  

20. ブラウザーのバック (←) ボタンを2回クリック、または [Cognitive Services の Web サイト](https://azure.microsoft.com/ja-jp/services/cognitive-services/) (<http://microsoft.com/cognitive>) に戻ります。  
  

#### Bing Web Search API

21. **Search (検索)** をクリックします。**Search (検索)** のページ内には、Web サイトや画像、動画、ニュースなど を様々な条件でインテリジェント検索する API 群が表示されています。  

<img src="media/CognitiveXamarinHOL_201806_16.PNG" width="450" height="291">  

20. **Bing Web Search** をクリックして開きます。Bing Web Search API は Web 検索結果を利用しやすい形で取得できます。  

<img src="media/CognitiveXamarinHOL_201806_17.PNG" width="450" height="291">  

21. 検索キーワードを入力し、マーケットや鮮度(情報が更新された日時)、 フィルター(セーフサーチ: 成人向けデータ表示の制限) を指定して、検索したデータが取得できることを確認してください。  

<img src="media/CognitiveXamarinHOL_201806_18.PNG" width="450" height="291">  

22. ブラウザーのバック (←) ボタンでひとつ前のページ (**検索** グループのページ) に戻ります。
  

#### Bing Visual Search

23. 次に **Bing Visual Search** をクリックして開きます。Bing Visual Search は画像を分析して、類似画像の検索や、テキスト抽出、著名人やランドマーク、ロゴに関する情報など、適切な情報を引き出す処理を行います。  

<img src="media/CognitiveXamarinHOL_201806_19.PNG" width="450" height="291">  

24. デモサイトで用意されている画像をクリックして、類似画像の検索やOCR(文字認識)、ランドマークやロゴ情報などが適切に表示されることを確認してください。  

<img src="media/CognitiveXamarinHOL_201806_20.PNG" width="450" height="291">  

#### Bing Autosuggest API

25. 今度は **Bing Autosuggest API** をクリックします。こちらはキーワードの一部を入力すると、それに続く言葉を推測し、表示します。  

<img src="media/CognitiveXamarinHOL_201806_21.PNG" width="450" height="291">  

26. キーワードを入力し、そこから推測される言葉が表示されることを確認してください。  

<img src="media/CognitiveXamarinHOL_201806_22.PNG" width="450" height="291">  
  

> 他にも Cognitive Services にはさまざまな機能を提供する API が用意されています。 Cognitive Services の API の機能を調べる場合は、まず [Web サイト](https://azure.microsoft.com/ja-jp/services/cognitive-services/) (<http://microsoft.com/cognitive>) のデモサイトで機能や動作を確認してください。
