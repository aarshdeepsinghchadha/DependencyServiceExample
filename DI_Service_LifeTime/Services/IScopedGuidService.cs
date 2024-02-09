namespace DI_Service_LifeTime.Services
{
    /// <summary>
    /// New Service - once per request
    /// </summary>
    public interface IScopedGuidService
    {
        string GetGuid();
    }
}
