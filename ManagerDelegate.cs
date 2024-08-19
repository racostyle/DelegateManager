using System.Collections.Generic;

namespace Managers
{
    public class ManagerDelegate
    {
        internal readonly ActionWrapperClasses.WrappedAction<string, string> EnableBulletFromPool =
            new ActionWrapperClasses.WrappedAction<string, string>();
    }
    
    //EXAMPLE
    private void Example()
    {
        EnableBulletFromPool.Register(ExampleAction);
    }

    private void ExampleAction(string arg1, string arg2)
    {
        
    }
}
