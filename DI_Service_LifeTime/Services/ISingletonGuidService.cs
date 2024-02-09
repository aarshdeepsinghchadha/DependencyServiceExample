namespace DI_Service_LifeTime.Services
{
    /// <summary>
    /// New Service - once per application lifetime
    /// </summary>
    public interface ISingletonGuidService
    {
        string GetGuid();
    }
}
