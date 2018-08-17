# **简易计算器**<br>
## *功能*：
1.支持四则运算和括号；<br>

2.可以保存和查询计算的历史记录，重启程序记录不丢失；<br>

3.有前面板进行人机交互；

## *如何实现*：

1.用C#调用js引擎的eval函数,利用eval函数将字符串形式的表达式转换为js代码并计算出结果。
```
//加载js引擎
        Microsoft.JScript.Vsa.VsaEngine ve = Microsoft.JScript.Vsa.VsaEngine.CreateEngine();
```
```
//计算结果
                result = Microsoft.JScript.Eval.JScriptEvaluate(this.text, ve).ToString();
```

2.将数据保存为txt文件

```
            string result1 = @"D:\history.txt";
            FileStream fs = new FileStream(result1, FileMode.Append);
            StreamWriter wr = null;
            wr = new StreamWriter(fs);
                wr.WriteLine(record[RecordNum-1]+ "=" + richTextBox1.Text);
            wr.Close();
```


## *计算器界面图：*


![](https://github.com/hust-p/homework1/blob/master/QQ%E5%9B%BE%E7%89%8720180813231633.png)
