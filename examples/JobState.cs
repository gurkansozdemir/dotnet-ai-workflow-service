public enum DemoJobState { Queued, Running, Completed, Failed }

public static class DemoJobTransitions
{
    public static bool TryStart(DemoJobState state, out DemoJobState next)
    {
        next = state == DemoJobState.Queued ? DemoJobState.Running : state;
        return state == DemoJobState.Queued;
    }
}
