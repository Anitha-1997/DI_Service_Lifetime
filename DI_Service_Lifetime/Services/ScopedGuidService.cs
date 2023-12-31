﻿namespace DI_Service_Lifetime.Services
{
    public class ScopedGuidService : IScopedGuidService

    {
        public readonly Guid Id;
        public ScopedGuidService()
        {
            Id = Guid.NewGuid();
        }
        public string GetGuid()
        {
            return Id.ToString();
        }
    }
}
