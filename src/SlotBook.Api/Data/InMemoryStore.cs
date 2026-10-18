using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

using SlotBook.api.Domain;
namespace SlotBook.api.Data;

public class InMemoryStore
{
    private readonly List<Slot> _slots = [];

    public IReadOnlyList<Slot> Slots => _slots;
    public void AddSlot(Slot slot) => _slots.Add(slot);
    public Slot? FindSlot(Guid id) => _slots.FirstOrDefault(s => s.Id == id);


    public InMemoryStore()
    {

    }
}