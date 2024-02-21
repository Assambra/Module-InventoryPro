using System;

namespace Assambra.General
{
    public interface ILocalIdentifier : IEquatable<ILocalIdentifier>
    {
        string ID { get; }

        string ToString();
    }
}
