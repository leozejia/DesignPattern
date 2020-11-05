using UnityEngine;

//策略模式，定义一组算法，让它们可以彼此交换使用。策略模式让这些算法在客户端使用它们时能更加独立
public abstract class Strategy
{
    public abstract void AlgorithmInterface();
}


//算法A
public class ConcreteStrategyA : Strategy
{
    public override void AlgorithmInterface()
    {
        Debug.Log("A");
    }
}
//算法B
public class ConcreteStrategyB : Strategy
{
    public override void AlgorithmInterface()
    {
        Debug.Log("B");
    }
}
