using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SlotBook.api.Domain;

public class Slot //public record Slot(Guid Id, string Resource, DateTimeOffset Start, DateTimeOffset End);
{
    public Guid Id { get; }
    public string Resource { get; }
    public DateTimeOffset Start { get; }
    public DateTimeOffset End { get; }

    public Slot(Guid id, string resource, DateTimeOffset start, DateTimeOffset end)
    {
        Id = id;
        Resource = resource;
        Start = start;
        End = end;
    }

    public override bool Equals(object? obj)
    {
        Slot? x = obj as Slot;
        if (x == null) return false;
        return Equals(x);
    }

    public bool Equals(Slot x)
    {
        if (x.Id != Id) return false;
        if (x.Resource != Resource) return false;
        if (x.Start != Start) return false;
        if (x.End != End) return false;
        return true;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Id, Resource, Start, End);
    }
}