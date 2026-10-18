using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SlotBook.api.Domain;

public record Booking(Guid Id, DateTimeOffset Start, DateTimeOffset End);
