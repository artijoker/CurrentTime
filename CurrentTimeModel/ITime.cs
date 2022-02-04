namespace CurrentTimeModel
{
    public interface ITime
    {
        DateTime GetCurrentUTCTime(int? hour = null, int? minute = null);
    }
}