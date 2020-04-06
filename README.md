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

# ウィンドウのサイズ変更方法

右下にグリップがあるので、左クリックを押下しながらドラッグ

# 注意事項
あくまで自分用に作成したので、たいしたテストはしていないです。

気が向いたら下記のことは対応するかもしれません。
* 取得間隔の改善
  * 今固定値になっていて、本当はAPIの戻り値のインターバルを使わないといけない
* ビルド済みモジュールのGitHubへの配置

# 利用したAPI
[Google Cloud Platform](https://console.developers.google.com/?hl=ja)

# デフォルトに設定してるフォント
[プログラミングフォント 白源 (はくげん／HackGen)](https://github.com/yuru7/HackGen)

# 参考
[Youtube Data APIを使用して、Youtube Liveのコメントを取得する || Qiita](https://qiita.com/MCK9595/items/fdbd543ff938febcd136)

[WPF - 枠無しウィンドウをリサイズおよび移動可能にしてみる || getBiboroku().get(Biboroku.Type.ALL)](http://getbget.seesaa.net/article/436398354.html)

