using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creator_GenericcClass<T> where T:Product, new()
{
    public Creator_GenericcClass()
    {
        Debug.Log("产生工程：Creator_GenericClass<" + typeof(T).ToString() + ">");
    }

    public Product FactoryMethod()
    {
        return new T();
    }
}

public abstract class Product
{ 
    
}

interface Creator_GenericMethod
{
    Product FactoryMethod<T>() where T : Product, new();
}

public class ConcreteCreator_GenericMethod : Creator_GenericMethod
{
    public ConcreteCreator_GenericMethod()
    {
        Debug.Log("产生工厂：ConcreteCreator_GenericMethod");
    }

    public Product FactoryMethod<T>() where T : Product, new()
    {
        return new T();
    }
}