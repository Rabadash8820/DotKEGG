﻿namespace DotKEGG {

    public sealed class MapNumber : KeggId {

        public MapNumber(uint number) {
            Number = number;
            _db = PathwayDb.Instance;
        }

        public PathwayDb Database => (PathwayDb)_db;

    }

}
