# YoutubeLiveComment
全画面のときにコメントを読めるようにコメントを前面表示するアプリケーション

# 使い方

## 初期設定
1. [Google Cloud Platform](https://console.developers.google.com/?hl=ja)へアクセス
2. Youtube Data API v3 のAPIキーを有効化
3. APIキーを設定ファイル（YoutubeLiveComment.dll.config）へ記入

## 配信時
1. 配信を作成
2. 配信のURLへ移動
3. URLからビデオIDを取得
4. ビデオIDを設定ファイル（YoutubeLiveComment.dll.config）へ記入

```
https://www.youtube.com/watch?v=[ビデオID]
```

# 注意事項
あくまで自分用に作成したので、たいしたテストはしていないです。

気が向いたら下記のことは対応するかもしれません。
* 設定
  ** フォント（色、サイズ）
  ** 背景色
  ** ウィンドウサイズ
* ビルド済みモジュールのGitHubへの配置

# 利用したAPI
[Google Cloud Platform](https://console.developers.google.com/?hl=ja)

# 参考
[Youtube Data APIを使用して、Youtube Liveのコメントを取得する || Qiita](https://qiita.com/MCK9595/items/fdbd543ff938febcd136)