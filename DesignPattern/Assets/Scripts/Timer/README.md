# MyTimer计时器

**MyTimer不在mono的生命周期下，所以需要在用的时候在mono下的Update里面去调用Tick方法，其中公共的参数有state（当前Timer的状态，IDLE表示静止，RUN表示正在计时，FINISHED表示计时结束）；duration（计时的时间，是一个float类型）**

## 使用方法

### MyTimerTEST

声明一个MyTimer变量

在Update里面调用Tick方法，并且判断timer的状态，如果变成FINISHED，表示计时结束

在恰当的时候设置duration，随后调用Go方法，即可开始计时

详见Demo中的MyTimerTEST

### RecordingDemo

带有录制动画的正计时demo



***



# MyButton点击状态

**MyButton是由MyTimer衍生出来的维护点击状态的类，每个按钮或者鼠标点击的时候，会有五个不同的状态，OnPressed（刚刚按下）、IsPressing（正在按）、OnReleased（释放的瞬间）、IsDelaying（刚刚按下开始的延迟）、IsExtending（刚刚释放开始的延迟）**

**需要注意的是，MyButton也不在mono的生命周期下，需要在mono下的Update中Tick，只是这次的Tick需要传入一个bool的参数，即**

![image-20200408152850950](E:\_Projects_Unity\IflyTek\BasicPackage\Assets\Scripts\Expand\Timer\image-20200408152850950.png)

## ButtonStateDemo

**详见ButtonStateDemo和ButtonStateTEST脚本**

## TriggerDemo

**用MyButton的机制来实现的Trigger，包括OnceTrigger（单击）、DobuleTrigger（双击）、Pressed（短按）、Pressing（长按）**

**详见TriggerDemo和TriggerTEST脚本**