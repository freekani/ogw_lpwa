# ogw_lpwa
### このプロジェクトについて
研究室で考案したサービスのモックです。
https://github.com/freekani/ogw_lpwa_server
でサーバー側のコードが公開されています。(インテグレーションの関係で分けています)
### 前提条件
.NET Core 3.1が導入されている(Linuxでもいけます)
### 使い方
1. このプロジェクトをクローンする
2. データを送信したいならowner、受信したいならuser側をカレントディレクトリにします。(cdコマンドね)
3. ```
   dotnet run
   ```
   とターミナルに入力
   します。
4. host?と聞かれたら[こちら](https://github.com/freekani/ogw_lpwa_server)のホスト名の欄に書かれている内容を入れてあげてください。
