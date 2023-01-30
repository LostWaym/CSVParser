# CSVParser

### 产生背景

​	在了解AST之后，进而对Lexer和Parser进行了了解，然后想实践一番，刚好csv的规则比较少，所以就写一个CSV的解析了。

### 使用方式

​	创建一个Lexer，调用它的Load方法传入csv字符串，再创建一个Parser将刚刚创建的Lexer作为它的构造函数参数，之后调用Parser的GetTable方法即可获得CSVTable。

​	CSVTable中的rows和columns分别代表行列数，通过Get方法可从CSVTable中取得字符串数据，当行列有误时，会返回null，不会报异常。