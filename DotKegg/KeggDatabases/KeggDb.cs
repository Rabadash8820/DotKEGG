﻿using System;

namespace DotKEGG {

    public abstract class KeggDb : IEquatable<KeggDb> {

        public string Name { get; protected set; }
        public string Abbreviation { get; protected set; }
        public string Prefix { get; protected set; }

        public abstract KeggId Entry(uint number);

        public override bool Equals(object obj) {
            KeggDb kdb = obj as KeggDb;
            if (kdb == null)
                return false;

            return kdb.Name == this.Name;
        }
        public bool Equals(KeggDb other) {
            if (ReferenceEquals(other, null))
                return false;
            return other.Name == this.Name;
        }
        public static bool operator ==(KeggDb left, KeggDb right) {
            if (ReferenceEquals(left, null))
                return ReferenceEquals(right, null);
            return left.Name == right.Name;
        }
        public static bool operator !=(KeggDb left, KeggDb right) {
            if (ReferenceEquals(left, null))
                return !ReferenceEquals(right, null);
            return left.Name != right.Name;
        }

        public override int GetHashCode() {
            return Name.GetHashCode();
        }
        public override string ToString() {
            return Name;
        }

    }

}
