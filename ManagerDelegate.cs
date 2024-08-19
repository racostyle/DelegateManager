using System.Collections.Generic;

namespace Managers
{
    public class ManagerDelegate
    {
        internal readonly ActionWrapperClasses.WrappedAction<string, string> Example =
            new ActionWrapperClasses.WrappedAction<string, string>();
    }
    
    //EXAMPLE
    private void Example()
    {
        //register
        Example.Register(ExampleAction);
        //calling
        Example?.Invoke("1", "2");
    }

    private void ExampleAction(string arg1, string arg2)
    {
        
    }
}
