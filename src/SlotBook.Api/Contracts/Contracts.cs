using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SlotBook.api.Contracts;

public record CreateSlotRequest(string Resource, DateTimeOffset Start, DateTimeOffset End);



