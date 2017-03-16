﻿namespace DotKEGG {

    public sealed class CNumber : KeggId {

        public CNumber(uint number) {
            Number = number;
            _db = CompoundDb.Instance;
        }

        public CompoundDb Database => _db as CompoundDb;

    }

}
