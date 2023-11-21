namespace Pattern;

/// <summary>
/// 데코레이터 패턴
/// 컴포넌트는 IComponent interface 를 상속 받아 구현
/// 데코레이터는 추상클레스 baseDecorator를 상속 받아 구현
/// baseDecorator 는 IComponent 를 상속 받은 상태
/// baseDecorator 에서 IComponent를 바로 상속 받아 사용 해도 되지만
/// Component와 Decorator 혼동 방지를 위해 baseDecorator 을 생성 해서 사용 하는거 같다..
/// Deco 가 추가 될때마다 baseDecorator 를 상속받아 작성
/// </summary>

public interface IComponent
{
    public void Operation();
}

public class ConcreteComponent  : IComponent
{
    public void Operation() => Console.Write("Concretecomponent");
}

public abstract class BaseDecorator : IComponent
{
    protected IComponent _component;
    public abstract void Operation();
}

public class Decorator1 : BaseDecorator
{
    public Decorator1(IComponent component) => _component = component;
    
    public override void Operation()
    {
        Console.Write("Decorator_1");
        _component.Operation();
    }
}

public class Decorator2 : BaseDecorator
{
    public Decorator2(IComponent component) => _component = component;
    
    public override void Operation()
    {
        Console.Write("Decorator_2");
        _component.Operation();
    }
}
