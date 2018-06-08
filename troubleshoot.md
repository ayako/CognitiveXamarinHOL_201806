トラブルシュート集
----

記憶にあるハマりポイントを書き出しています。ハンズオン中あるいはその後の参考にしてください。

# Mac + Visual Studio for Mac を使う人向け

## 1. Xcode のバージョンが古い

使用している Visual Studio for Mac(VS4M)に対応した Xcode のバージョンでないと、iOS アプリのビルド時に次のようなエラーが出ます。

```
MTOUCH : error MT0091: This version of Xamarin.iOS requires the iOS 11.3 SDK (shipped with Xcode 9.3). 
Either upgrade Xcode to get the required header files or set the managed linker behaviour to Link Framework SDKs Only (to try to avoid the new APIs).
```

Xcode をバージョンアップするのが一番よいですが、環境の問題できない場合は、iOS プロジェクトの設定で、iOS Build -> Linker Behavior を "Don't Link" から 
"Link Framework SDKs Only" に変更します。

## 2. Xcode を一度も起動していない

Xcode を一度も起動していない場合、iOS アプリのビルド時に

* 利用規約に同意してない
* コマンドラインツールが入ってない

という旨のメッセージが出た記憶があります。Xcode を初回起動するとこれらの実施を促されるので行ってください。


## 3. ビルドすると 「package.config が見つからない」という旨のエラーメッセージが出る

すべてのプロジェクトから ``Microsoft.Bcl.Build`` nuget パッケージを削除してください。
削除した状態でもアプリは動作しました（なぜこれが必要かわかりません）。


end of contents.
