# ZoomCaptioner

Zoomに、1人で字幕をつけるツールです。

元々、合計2時間ほどで作った手抜きツールなので、いまいちな部分はforkした上で改造して、できれば公開してもらえると嬉しいかも。

バージョン1.1で。動作する.NET Frameworkを4.7以上としました。これは高DPI対応（高解像度ディスプレイ対応）のためです。サポートされているWindows10であれば、問題はないはずです。

## 作った動機

Zoomの字幕入力機能が酷いから作りました。

- Zoomは画面共有の状態が変わると、アプリケーション全体の表示がリフレッシュされるらしく、字幕入力中だと、入力が途切れたり、最悪フォーカスがずれたりする。
- 字幕ウインドウは、入力欄は1行しかないはずなのに、下に巨大な空間（特に機能なし）があるなど、無駄に大きく画面を占有してしまう。
- 時々字幕ウインドウが消えて、再度出してみると、日本語のインライン入力がおかしいことがある（IMEによる確定までのフォントと確定後のフォントが違っていて見づらいなど）。
- 字幕ウインドウの文字はフォント種類もフォントサイズもいじれない。はっきり言って見づらい。

## 使い方

起動して、「Zoom APIトークン」のところにZoomの字幕API用のトークン（中身はURL）を貼り付けます。

（字幕API用のトークンは、ホスト（あるいは、ホストから字幕入力を割り当てられた参加者）なら、「サードパーティのCCサービス」とかいった辺りをクリックすると、クリップボードにコピーされます）

上から2つめの入力欄が、字幕テキスト入力欄です。ここに字幕を入力して、Enterキーを押すと、字幕が送信できます。

## 入力欄の特殊機能

- Enterキーを押すと、入力欄が空でなければ、入力欄の中の文言をZoom字幕として送出します。
- F1～F7キーを押すと、入力欄下の、押したキーに対応する枠に入った言葉が挿入されます（該当枠が空の場合は何も起きません）。
- F8キーを押すと、入力欄の文言全体がカギカッコで囲まれます。
- Shiftキーを押しながらF8キーを押すと、入力欄の文言全体が全角カッコで囲まれます。
- ESCキーを押すと、入力欄の文字列が消えます。この動作は取消できないのでご注意ください。

## 画面に存在する要素の補足説明

入力欄より下の枠は、短縮入力機能の登録枠です。ここに文言（例えば話者名を示す文字列など）を入れておくと、入力欄でF1～F7キーを押した時に、対応する文字列が、カーソル位置に挿入されます。

一番下はログ領域です。今のところ、エラー時にステータスコードとステータスに関する説明文字列が入ります。

ログ領域の上には、

- ボタン「シーケンス初期化（字幕が出ない時に押す）」は、字幕を送った時にエラーにんらないにも関わらず字幕が表示されない場合に押してください。本来なら、こういう事態はアプリケーションで検出すべきなのですが、Zoom字幕APIの動作上、検出できないケースがあるので手動対応となっています。
- チェックボックス「最前面に配置」は、チェックを入れると、このアプリケーションが他のアプリケーションよりも常に手前に表示されます。例えばZoomに重ねて使う場合に便利かもしれません。

## mekiku-webとは連動しないの？

連動しません。

mekiku-webをZoom字幕APIに対応させるのは、クライアント側コードだけではできないので、将来の課題としておきます。

## 参考

字幕とライブ文字起こし
https://support.zoom.us/hc/ja/articles/207279736-%E5%AD%97%E5%B9%95%E3%81%A8%E3%83%A9%E3%82%A4%E3%83%96%E6%96%87%E5%AD%97%E8%B5%B7%E3%81%93%E3%81%97
