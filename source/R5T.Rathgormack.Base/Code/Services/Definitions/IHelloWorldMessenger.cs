using System;using R5T.T0064;


namespace R5T.Rathgormack
{[ServiceDefinitionMarker]
    public interface IHelloWorldMessenger:IServiceDefinition
    {
        void SendHelloWorldMessage();
    }
}
