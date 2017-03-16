﻿using System.Collections.Generic;

namespace DotKEGG {

    public sealed class PathwayDb : KeggDb {

        private static PathwayDb _instance = new PathwayDb();

        private PathwayDb() {
            Name = "pathway";
            Abbreviation = "path";
            Prefix = "map";
        }

        public static PathwayDb Instance => _instance;

        public static MapNumber NewMapNumber(uint number) {
            return new MapNumber(number);
        }

    }

}
