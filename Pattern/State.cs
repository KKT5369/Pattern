namespace Pattern;

/// <summary>
/// 상태에 따른 추상클레스 생성
/// 추상클레스 구현 하여 상황에 맞는 상태 구현
/// Context 에서 넘겨받는 상태에 따라 그에 맞는 로직 실행
/// 상태가 추가 될때마나 State 를 상속받아 구현
/// </summary>

public abstract class State
{
    public abstract void Handle(Context context);
}

public class Context
{
    public Context(State state) => _state = state;
    protected State _state;
    public State State
    {
        get { return _state;}
        set
        {
            _state = value;
        }
    }
    
    public void Requesst()
    {
        _state.Handle(this);
    }
}

class ConcreteStateA : State
{
    public override void Handle(Context context)
    {
        Console.WriteLine("1번 스킬");
    }
}

internal class ConcreteStateB : State
{
    public override void Handle(Context context)
    {
        Console.WriteLine("2번 스킬");
    }
}
