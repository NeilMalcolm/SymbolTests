namespace SymbolTests.Classes;

public class ClassFactory 
{
    public BaseClass Get()
    {
#if AUTOMATION
    return new AutomationClass();
#elif DEBUG
    return new DebugClass();
#else
    return new ReleaseClass();
#endif
    }
}