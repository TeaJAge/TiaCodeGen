﻿using TiaCodegen.Commands.Signals;
using TiaCodegen.Interfaces;

namespace TiaCodegen.Commands.Coils
{
    public class SCoil : BaseCoil
    {
        public SCoil(Signal signal, IOperationOrSignal op = null) : base(signal, op)
        { }
    }
}
