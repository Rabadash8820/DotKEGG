﻿namespace DotKEGG {

    public sealed class BrNumber : KeggId {

        public BrNumber(uint number) {
            Number = number;
            _db = BriteDb.Instance;
        }

        public BriteDb Database => (BriteDb)_db;

    }

}
